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
using System.Text.RegularExpressions;

namespace ItemManager
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        EmpDataBLL ebll = new EmpDataBLL();
        empObjects eobj = new empObjects();
        DataTable td = new DataTable();
     
        public Settings()
        {
            InitializeComponent();
         
        }

        public bool validationFeilds()
        {
            string strValidation = "";

            if (txtEmpPhnNo.Text == string.Empty)
            {
                strValidation = "Please fill the PhoneNumber\n";
            }
            Regex expr = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (!expr.IsMatch(txtEmpPhnNo.Text))
            {
                strValidation = strValidation + "Please fill a valid Phone Number\n";
            }
            if (txtempEmail.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill EmailAddress\n";
            }
            Regex exprr = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!exprr.IsMatch(txtempEmail.Text))
            {
                strValidation = strValidation + "Please fill a valid Email Address\n";
            }
            if (txtempAddress.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Address\n";
            }
            if (txtState.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill State\n"; ;
            }
           
            if (strValidation != "")
            {
                MessageBox.Show(strValidation, "Please fill the following", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Settings_Load(object sender, EventArgs e)
        {   
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        public void newname(string myname)
        {
            UName.Text = myname;
            extUserName.Text = myname;
            label10.Text = myname;
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Opacity= 0.97;
            panel1.Visible = true;
            panel1.Width= 727;
            panel1.Height=262;
            panel2.Visible = false;
            panel3.Visible = false;
            UName.Enabled = false;
           
            


        }
       


        private void metroTile2_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = 0.97;
            panel2.Visible = true;
            panel2.Width = 630;
            panel2.Height = 262;
            panel1.Visible = false;
            panel3.Visible = false;
            extUserName.Enabled = false;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = 0.97;
            panel3.Visible = true;
            panel3.Width = 630;
            panel3.Height = 262;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void editEmpProfie_Click(object sender, EventArgs e)
        {   if (validationFeilds()== true) { 
            validationFeilds();
            string phNumber = txtEmpPhnNo.Text;
            string email = txtempEmail.Text;
            string address = txtempAddress.Text;
            string state = txtState.Text;
            string ID = label10.Text;
            BLL.EmpDataBLL.editemp(phNumber, email, address, state, ID);
            MessageBox.Show("Profile Updated !!");
            txtEmpPhnNo.Text = string.Empty;
            txtempEmail.Text= string.Empty;
            txtempAddress.Text= string.Empty;
            txtState.Text= string.Empty;
            }
       

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           if(newUserName.Text==string.Empty)
                
            { MessageBox.Show("Please fill the Username First", "Please fill th following", MessageBoxButtons.OK); }
            else { 
                if (newUserName.TextLength<6)
                { label11.Visible = true;
                  }
                else { 
                    string ID = newUserName.Text;
                    BLL.EmpDataBLL.UsernameUpd(ID);
                    newUserName.Text = string.Empty;
                    DialogResult Confirm = MessageBox.Show("Please click OK to see changes Note: Required Application Reboot!!", "See Changes Now", MessageBoxButtons.OKCancel);
                    if (Confirm == DialogResult.OK)
                    {

                        Application.Restart();

                    }
                }
            }

        }

        private void pswdUpdate_Click(object sender, EventArgs e)
        {
            string ID = txtOldPswd.Text;
            string newpsd= txtNewPSd.Text;
            string user = label10.Text;
            if ( txtOldPswd.Text== string.Empty || txtNewPSd.Text==string.Empty )
            {
                MessageBox.Show("Please fill the both Fields", "Please fill the following", MessageBoxButtons.OK);
            }
            else
            {
                BLL.EmpDataBLL.pssupdate(ID, newpsd,user);
                MessageBox.Show("Password Updated", "Sucess", MessageBoxButtons.OK);
                txtOldPswd.Text = "";
                txtNewPSd.Text = "";
            }

        }
    }



        }
    
                                                           