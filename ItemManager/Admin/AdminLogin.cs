using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemManager.DTO;
using ItemManager.BLL;

namespace ItemManager.Admin
{
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        empObjects eObj = new empObjects();
        EmpDataBLL edll = new EmpDataBLL();
        DataTable td = new DataTable();
        adDashBoard ad = new adDashBoard();
        Admin.AdSettingsPanel adminsetter = new AdSettingsPanel();
        public AdminLogin()
        {
            InitializeComponent();
        }
        string Adminame;
        private void admin_Click(object sender, EventArgs e)
        {
           eObj.Admin  = AdName.Text;
            eObj.AdminPass = adPass.Text;
            td=edll.adlogin(eObj);

        

            if (td.Rows.Count>0)
            {
              
                this.Hide();
                ad.td =td;
                ad.Show();
                this.Hide();

            }
        else { MessageBox.Show("Login Failed "); }

        }

        
        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin.LoginPannel banner = new LoginPannel();
            banner.Show();

        }
    }
}
