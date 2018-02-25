namespace ItemManager.Admin
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.AdName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.admin = new MetroFramework.Controls.MetroButton();
            this.adPass = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdName
            // 
            // 
            // 
            // 
            this.AdName.CustomButton.AutoSize = true;
            this.AdName.CustomButton.Image = null;
            this.AdName.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.AdName.CustomButton.Name = "";
            this.AdName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AdName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdName.CustomButton.TabIndex = 1;
            this.AdName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AdName.CustomButton.UseSelectable = true;
            this.AdName.CustomButton.Visible = false;
            this.AdName.Lines = new string[0];
            this.AdName.Location = new System.Drawing.Point(238, 76);
            this.AdName.MaxLength = 32767;
            this.AdName.Name = "AdName";
            this.AdName.PasswordChar = '\0';
            this.AdName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdName.SelectedText = "";
            this.AdName.SelectionLength = 0;
            this.AdName.SelectionStart = 0;
            this.AdName.ShortcutsEnabled = true;
            this.AdName.Size = new System.Drawing.Size(181, 23);
            this.AdName.TabIndex = 0;
            this.AdName.UseSelectable = true;
            this.AdName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AdName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(109, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(109, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password ";
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(344, 161);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 28);
            this.admin.TabIndex = 3;
            this.admin.Text = "Login";
            this.admin.UseSelectable = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // adPass
            // 
            // 
            // 
            // 
            this.adPass.CustomButton.AutoSize = true;
            this.adPass.CustomButton.Image = null;
            this.adPass.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.adPass.CustomButton.Name = "";
            this.adPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adPass.CustomButton.TabIndex = 1;
            this.adPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adPass.CustomButton.UseSelectable = true;
            this.adPass.CustomButton.Visible = false;
            this.adPass.Lines = new string[0];
            this.adPass.Location = new System.Drawing.Point(238, 121);
            this.adPass.MaxLength = 32767;
            this.adPass.Name = "adPass";
            this.adPass.PasswordChar = '*';
            this.adPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adPass.SelectedText = "";
            this.adPass.SelectionLength = 0;
            this.adPass.SelectionStart = 0;
            this.adPass.ShortcutsEnabled = true;
            this.adPass.Size = new System.Drawing.Size(181, 23);
            this.adPass.TabIndex = 2;
            this.adPass.UseSelectable = true;
            this.adPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adPass);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AdName);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox AdName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton admin;
        private MetroFramework.Controls.MetroTextBox adPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}