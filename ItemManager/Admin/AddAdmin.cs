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
    public partial class AddAdmin : MetroFramework.Forms.MetroForm
    {
        public AddAdmin()
        {
            InitializeComponent();


        }

        DTO.empObjects eobj = new empObjects();
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (AdminName.Text == string.Empty || AdminPassword.Text == string.Empty)
            { Notify.Text = "Please Fill Both Fields "; }
            else
            {
                eobj.Admin = AdminName.Text;
                eobj.AdminPass = AdminPassword.Text;
                BLL.EmpDataBLL.AdnewAdmin(eobj);
                MessageBox.Show("New Admin Added Sucessfully");
                this.Hide();
                AdminName.Text = string.Empty;
                AdminPassword.Text = string.Empty;
            }
        }
    }
}