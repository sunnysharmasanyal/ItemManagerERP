using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemManager.BLL;
using ItemManager.DTO;


namespace ItemManager.Admin
{
    public partial class AdSettingsPanel : MetroFramework.Forms.MetroForm
    {
        public AdSettingsPanel()
        {
            InitializeComponent();
        }
        public string adminName;
        public string AdminID;
       
        private void AdPswdUpdate_Click(object sender, EventArgs e)
        {
            
            string newpsd = txtNewPSd.Text;
            string user = adName.Text;
            if ( txtNewPSd.Text == string.Empty)
            {
                MessageBox.Show("Please fill the both Fields", "Please fill the following", MessageBoxButtons.OK);
            }
            else
            {
                BLL.EmpDataBLL.AdPassupd( newpsd, user);
                MessageBox.Show("Password Updated", "Sucess", MessageBoxButtons.OK);
              
                txtNewPSd.Text = "";
            }
        }

        private void BtnUNameUPD_Click(object sender, EventArgs e)
        {

            if (newUserName.Text == string.Empty)

            { MessageBox.Show("Please fill the Username First", "Please fill th following", MessageBoxButtons.OK); }
            else
            {
                if (newUserName.TextLength < 6)
                {
                    label11.Visible = true;
                }
                else
                {
                    string ID = newUserName.Text;
                    string Existing = AdminID;
                    BLL.EmpDataBLL.AdUsernameUpd(ID,Existing);
                    newUserName.Text = string.Empty;
                    DialogResult Confirm = MessageBox.Show("Please click OK to see changes Note: Required Application Reboot!!", "See Changes Now", MessageBoxButtons.OKCancel);
                    if (Confirm == DialogResult.OK)
                    {

                        Application.Restart();

                    }
                }
            }
        }
       
        private void AdSettingsPanel_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            adName.Text = adminName;
            UName.Enabled = false;
            UName.Text = adminName;
            extUserName.Enabled = false;
            extUserName.Text = adminName;
            AName.Enabled = false;
            AName.Text = AdminID;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           ActiveForm.Opacity = 0.97;
            panel1.Visible = true;
            panel1.Width = 727;
            panel1.Height = 262;
            panel2.Visible = false;
            panel3.Visible = false;
          
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = 0.97;
            panel2.Visible = true;
            panel2.Width = 630;
            panel2.Height = 262;
            panel1.Visible = false;
            panel3.Visible = false;
          
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = 1;
            panel3.Visible = true;
            panel3.Width = 630;
            panel3.Height = 262;
            panel2.Visible = false;
            panel1.Visible = false;
           
        }

        private  void  BtnAdminRemove_Click(object sender, EventArgs e)
        {
            String ID = AName.Text;
            BLL.EmpDataBLL.AdRemove(ID);
                 

                Application.Restart();

            

        }
    }
}
                                              