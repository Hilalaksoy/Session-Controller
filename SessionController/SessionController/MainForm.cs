using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing.Drawing2D;
using System.Security.Principal;
using System.Diagnostics;
using System.Net.NetworkInformation;
using SessionController.ServiceReference1;
using SessionController.ServiceReference2;

namespace SessionController
{
    public partial class MainForm : Form
    {
        public static UserAuthenticationSoapClient servis2;
        public static AddLoginInfoSoapClient servis;
        public bool Locked { get; set; }
        public static string MacAdres { get; set; }
        public static string KullaniciAdi { get; set; }
        public static string Durum { get; set; }


        //Klavye kısayol tuşlarını devre dışı bırakma.(Örn:CTRL+F4, CTRL+C..)
        #region " Disable Special Keys"

        private delegate int LowLevelKeyboardProcDelegate(int nCode, int
            wParam, ref KBDLLHOOKSTRUCT lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi)]
        private static extern int SetWindowsHookEx(
           int idHook,
           LowLevelKeyboardProcDelegate lpfn,
           int hMod,
           int dwThreadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(int hHook);


        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Ansi)]
        private static extern int CallNextHookEx(
            int hHook, int nCode,
            int wParam, ref KBDLLHOOKSTRUCT lParam);


        const int WH_KEYBOARD_LL = 13;
        private int intLLKey;
        private KBDLLHOOKSTRUCT lParam;

        public object Interaction { get; private set; }
        public object MsgBoxStyle { get; private set; }

        private struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        private int LowLevelKeyboardProc(
            int nCode, int wParam,
            ref KBDLLHOOKSTRUCT lParam)
        {
            bool blnEat = false;
            switch (wParam)
            {
                case 256:
                case 257:
                case 260:
                case 261:
                    //Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key
                    if (((lParam.vkCode == 9) && (lParam.flags == 32)) ||
                    ((lParam.vkCode == 27) && (lParam.flags == 32)) || ((lParam.vkCode ==
                    27) && (lParam.flags == 0)) || ((lParam.vkCode == 91) && (lParam.flags
                    == 1)) || ((lParam.vkCode == 92) && (lParam.flags == 1)) || ((true) &&
                    (lParam.flags == 32)))
                    {
                        blnEat = true;
                    }
                    break;
            }
            if (blnEat)
                return 1;
            else return CallNextHookEx(0, nCode, wParam, ref lParam);

        }

        public void KeyboardHook(object sender, EventArgs e)
        {
            intLLKey =
                SetWindowsHookEx(

                WH_KEYBOARD_LL,
                 new LowLevelKeyboardProcDelegate(LowLevelKeyboardProc),

                System.Runtime.InteropServices.Marshal.GetHINSTANCE(
                  System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
        }

        public void ReleaseKeyboardHook()
        {
            intLLKey = UnhookWindowsHookEx(intLLKey);
        }



        private void DisableCtrlAltDel()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);

            rkey.CreateSubKey("System", RegistryKeyPermissionCheck.Default);

            rkey.Close();

            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);

            rkey2.SetValue("DisableTaskMgr", 1);
            rkey2.Close();

        }
        private void EnableCtrlAltDel()
        {
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);

            rkey.CreateSubKey("System", RegistryKeyPermissionCheck.Default);

            rkey.Close();

            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);

            rkey2.SetValue("DisableTaskMgr", 0);
            rkey2.Close();
        }

        #endregion



        public MainForm()
        {
            InitializeComponent();
            Locked = false;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            KeyboardHook(this, e);
            DisableCtrlAltDel();
      
            servis = new AddLoginInfoSoapClient();
            servis.UserDetailsValue = new ServiceReference1.UserDetails()
            {
                userName = "username",
                password = "password"
            };

            servis2 = new UserAuthenticationSoapClient();
            servis2.UserDetailsValue = new ServiceReference2.UserDetails()
            {
                userName = "username",
                password = "password"
            };

        }

        //Bilgisayarın mac adresini alma
        private string GetMacAddress()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            return nics.First().GetPhysicalAddress().ToString();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            KullaniciAdi = kullaniciAdiTextBox.TextValue;
            string Parola = parolaTextBox.TextValue;
            try
            {
                //Sabisten doğrulama
                if (servis2.Check(servis2.UserDetailsValue, KullaniciAdi, Parola))
                {
                    this.Hide();
                    //Küçültme  işlemi
                    ReleaseKeyboardHook();
                    EnableCtrlAltDel();
                    Locked = false;
                    MacAdres = GetMacAddress();
                    Durum = "Enter";
                    string bilgi = servis.AddInfo(servis.UserDetailsValue,KullaniciAdi, MacAdres, Durum);                   
                    MessageBox.Show(bilgi);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ya da parola geçersiz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Görev çubuğunda proje ikonunun gösterimi
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ExitSession exitSession = new ExitSession();
            exitSession.Show();
            this.Hide(); 
            notifyIcon1.Visible = false;
        }

        //Yeniden boyutlandırma 
        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

      
    }
}
