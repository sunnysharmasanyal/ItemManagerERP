namespace ItemManager.Admin
{
    partial class AdSettingsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdSettingsPanel));
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnUNameUPD = new System.Windows.Forms.Button();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.extUserName = new System.Windows.Forms.TextBox();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAdminRemove = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.AName = new System.Windows.Forms.TextBox();
            this.adName = new System.Windows.Forms.Label();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.AdPswdUpdate = new System.Windows.Forms.Button();
            this.txtNewPSd = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(507, 59);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(142, 63);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile3.TabIndex = 13;
            this.metroTile3.Text = "       Remove Admin";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(440, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 34);
            this.label11.TabIndex = 5;
            this.label11.Text = "Username Must be 5\r\n Character long";
            this.label11.Visible = false;
            // 
            // BtnUNameUPD
            // 
            this.BtnUNameUPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUNameUPD.Location = new System.Drawing.Point(359, 126);
            this.BtnUNameUPD.Name = "BtnUNameUPD";
            this.BtnUNameUPD.Size = new System.Drawing.Size(75, 23);
            this.BtnUNameUPD.TabIndex = 4;
            this.BtnUNameUPD.Text = "Update";
            this.BtnUNameUPD.UseVisualStyleBackColor = true;
            this.BtnUNameUPD.Click += new System.EventHandler(this.BtnUNameUPD_Click);
            // 
            // newUserName
            // 
            this.newUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserName.Location = new System.Drawing.Point(256, 81);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(178, 26);
            this.newUserName.TabIndex = 3;
            // 
            // extUserName
            // 
            this.extUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extUserName.Location = new System.Drawing.Point(256, 41);
            this.extUserName.Name = "extUserName";
            this.extUserName.Size = new System.Drawing.Size(178, 26);
            this.extUserName.TabIndex = 2;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(0, 125);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(764, 10);
            this.metroTile5.TabIndex = 15;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Username";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BtnUNameUPD);
            this.panel2.Controls.Add(this.newUserName);
            this.panel2.Controls.Add(this.extUserName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(84, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 224);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Existing UserName";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnAdminRemove);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.AName);
            this.panel3.Location = new System.Drawing.Point(84, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 224);
            this.panel3.TabIndex = 17;
            // 
            // BtnAdminRemove
            // 
            this.BtnAdminRemove.Location = new System.Drawing.Point(156, 130);
            this.BtnAdminRemove.Name = "BtnAdminRemove";
            this.BtnAdminRemove.Size = new System.Drawing.Size(303, 23);
            this.BtnAdminRemove.TabIndex = 19;
            this.BtnAdminRemove.Text = "Remove Your Admin Rights";
            this.BtnAdminRemove.UseSelectable = true;
            this.BtnAdminRemove.Click += new System.EventHandler(this.BtnAdminRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Your Admin ID";
            // 
            // AName
            // 
            this.AName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AName.Location = new System.Drawing.Point(265, 73);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(194, 26);
            this.AName.TabIndex = 11;
            // 
            // adName
            // 
            this.adName.AutoSize = true;
            this.adName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.adName.Location = new System.Drawing.Point(652, 37);
            this.adName.Name = "adName";
            this.adName.Size = new System.Drawing.Size(89, 18);
            this.adName.TabIndex = 9;
            this.adName.Text = "AdminName";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(322, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(166, 59);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "        Change UserName";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // AdPswdUpdate
            // 
            this.AdPswdUpdate.FlatAppearance.BorderSize = 3;
            this.AdPswdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdPswdUpdate.Location = new System.Drawing.Point(359, 137);
            this.AdPswdUpdate.Name = "AdPswdUpdate";
            this.AdPswdUpdate.Size = new System.Drawing.Size(75, 23);
            this.AdPswdUpdate.TabIndex = 6;
            this.AdPswdUpdate.Text = "Update";
            this.AdPswdUpdate.UseVisualStyleBackColor = true;
            this.AdPswdUpdate.Click += new System.EventHandler(this.AdPswdUpdate_Click);
            // 
            // txtNewPSd
            // 
            this.txtNewPSd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPSd.Location = new System.Drawing.Point(265, 86);
            this.txtNewPSd.Name = "txtNewPSd";
            this.txtNewPSd.PasswordChar = '*';
            this.txtNewPSd.Size = new System.Drawing.Size(169, 26);
            this.txtNewPSd.TabIndex = 5;
            // 
            // UName
            // 
            this.UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.Location = new System.Drawing.Point(265, 38);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(169, 26);
            this.UName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AdPswdUpdate);
            this.panel1.Controls.Add(this.txtNewPSd);
            this.panel1.Controls.Add(this.UName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 224);
            this.panel1.TabIndex = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(127, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(175, 59);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "         Change Password";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AdSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 407);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.adName);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTile1);
            this.Name = "AdSettingsPanel";
            this.Text = "AdSettingsPanel";
            this.Load += new System.EventHandler(this.AdSettingsPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnUNameUPD;
        private System.Windows.Forms.TextBox newUserName;
        private System.Windows.Forms.TextBox extUserName;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.Button AdPswdUpdate;
        private System.Windows.Forms.TextBox txtNewPSd;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label adName;
        private System.Windows.Forms.TextBox AName;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton BtnAdminRemove;
    }
}