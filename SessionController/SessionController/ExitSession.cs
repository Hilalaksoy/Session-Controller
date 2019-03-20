using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SessionController
{
    public partial class ExitSession : Form
    {
        public ExitSession()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.Enabled = false;
            MainForm.Durum = "Exit";
            string mesaj = MainForm.servis.AddInfo(MainForm.servis.UserDetailsValue,MainForm.KullaniciAdi, MainForm.MacAdres,MainForm.Durum);
            MessageBox.Show(mesaj);          
            //Oturum Kapat
            //System.Diagnostics.Process.Start("shutdown", "-l -f");
            exitButton.Enabled = true;
        }
    }
}
