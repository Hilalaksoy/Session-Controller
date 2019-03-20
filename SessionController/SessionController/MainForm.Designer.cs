namespace SessionController
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisButton = new System.Windows.Forms.Button();
            this.parolaTextBox = new JTextBox.JTextBox();
            this.kullaniciAdiTextBox = new JTextBox.JTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.SystemColors.Control;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(213, -6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(391, 100);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.girisButton);
            this.panel1.Controls.Add(this.parolaTextBox);
            this.panel1.Controls.Add(this.kullaniciAdiTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(213, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 284);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(106, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bilgisayar Laboratuvarı";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bilgisayar ve Bilişim Bilimleri Fakültesi";
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.girisButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.girisButton.FlatAppearance.BorderSize = 2;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.girisButton.Location = new System.Drawing.Point(71, 225);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(230, 30);
            this.girisButton.TabIndex = 3;
            this.girisButton.Text = "Giriş";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.AutoSize = true;
            this.parolaTextBox.BorderColor = System.Drawing.Color.Gray;
            this.parolaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.parolaTextBox.Hint = "parola";
            this.parolaTextBox.IsPassword = true;
            this.parolaTextBox.Length = 0;
            this.parolaTextBox.Location = new System.Drawing.Point(47, 170);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.OnFocus = System.Drawing.Color.DarkGray;
            this.parolaTextBox.OnlyChar = false;
            this.parolaTextBox.OnlyNumber = false;
            this.parolaTextBox.Size = new System.Drawing.Size(282, 39);
            this.parolaTextBox.TabIndex = 2;
            this.parolaTextBox.TextValue = "parola";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.AutoSize = true;
            this.kullaniciAdiTextBox.BorderColor = System.Drawing.Color.Gray;
            this.kullaniciAdiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kullaniciAdiTextBox.Hint = "kullanıcı adı";
            this.kullaniciAdiTextBox.IsPassword = false;
            this.kullaniciAdiTextBox.Length = 0;
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(47, 109);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.OnFocus = System.Drawing.Color.DarkGray;
            this.kullaniciAdiTextBox.OnlyChar = false;
            this.kullaniciAdiTextBox.OnlyNumber = false;
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(282, 39);
            this.kullaniciAdiTextBox.TabIndex = 1;
            this.kullaniciAdiTextBox.TextValue = "kullanıcı adı";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabis bilgileri ile giriş yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Deneme";
            this.notifyIcon1.BalloonTipTitle = "Giriş Uygulaması";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Oturumu kapatmak için tıklayınız.";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.Name = "MainForm";
            this.Text = "Session Controller";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JTextBox.JTextBox parolaTextBox;
        private JTextBox.JTextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

