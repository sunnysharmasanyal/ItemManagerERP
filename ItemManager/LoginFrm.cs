using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemManager.BLL;
using ItemManager.DTO;

namespace ItemManager
{
    public partial class LoginFrm : MetroFramework.Forms.MetroForm
    {
    
        public empObjects eobj = new empObjects();
        public EmpDataBLL ebll = new EmpDataBLL();
        DataTable dt = new DataTable();
       
        
        string myname;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {      
           
            eobj.username = tUName.Text;
            eobj.password = tUPassword.Text;
           dt= ebll.LoginBLL(eobj);
           if(dt.Rows.Count>0)
            {

                MessageBox.Show("Login Attempt sucessful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainUI miui = new MainUI();
                miui.Show();
                this.Hide();

            }
           else
            {
                MessageBox.Show("Login Attempt unsucessful","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );

            }

        }

                       

        private void LoginFrm_Load(object sender, EventArgs e)
        {
         
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            MainUI mi = new MainUI();
            metroLabel1.ForeColor = Color.Blue;
            eobj.username = tUName.Text;
            eobj.password = tUPassword.Text;
            dt = ebll.LoginBLL(eobj);
            myname = eobj.username;
          
            mi.UserNFetch(myname);
            


            if (dt.Rows.Count > 0)
            {

               
                
                mi.Show();
                this.Hide();

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Login Failed";

            }
        }

        private void LoginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin.LoginPannel banner = new Admin.LoginPannel();
           banner.Show();
        }

        private void tUPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

       
    }
    }
