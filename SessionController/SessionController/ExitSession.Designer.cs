namespace SessionController
{
    partial class ExitSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitSession));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.logo.Location = new System.Drawing.Point(280, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(270, 100);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(280, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 76);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitButton.Location = new System.Drawing.Point(17, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(230, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Çıkış";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ExitSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitSession";
            this.Text = "ExitSession";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
    }
}