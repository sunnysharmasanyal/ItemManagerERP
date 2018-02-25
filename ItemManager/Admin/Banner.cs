using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms
                        ; 
namespace ItemManager.Admin
{
    public partial class LoginPannel : MetroFramework.Forms.MetroForm
    {
        public LoginPannel()
        {
            InitializeComponent();
        }

        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            LoginFrm lfm = new LoginFrm();
            lfm.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Admin.AdminLogin adlog = new AdminLogin();
            adlog.Show();
            this.Hide();
        }

      
    }
}
