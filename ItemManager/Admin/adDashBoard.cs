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
using System.IO;

namespace ItemManager.Admin
{
    public partial class adDashBoard : Form
    {
        public adDashBoard()
        {
            InitializeComponent();

        }
        empObjects eobj = new empObjects();
        EmpDataBLL ebll = new EmpDataBLL();
       public DataTable td = new DataTable();
        Admin.AdSettingsPanel adminsetter = new AdSettingsPanel();

        private void adDashBoard_Load(object sender, EventArgs e)
        {
            DateTime lbldate = DateTime.Now;
            LblDate.Text = lbldate.ToString("MMMM:"+" "+"dddd:"+" "+"yyyy");
            label3.Visible = true;
            label4.Visible = true;

            label3.Text =td.Rows[0][1].ToString();
           

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            EmpADD addnew = new ItemManager.EmpADD();
            addnew.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin.LoginPannel banner = new LoginPannel();
            banner.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Removefrm rf = new Removefrm();
            rf.ShowDialog();
        }

        private void EmpName_TextChanged(object sender, EventArgs e)
        {
            string ename = EmpName.Text;
            string estate = eState.Text;
            if (EmpName.Text == string.Empty && eState.Text == string.Empty) { GridAdmin.DataSource = null; }
            else
            {
                GridAdmin.DataSource = ebll.adminload(ename, estate);
                GridAdmin.Columns[6].Visible = false;
            }
            
        }              
        private void eState_TextChanged(object sender, EventArgs e)
        {
            string ename = EmpName.Text;
            string estate = eState.Text;
            if (EmpName.Text == string.Empty && eState.Text == string.Empty) { GridAdmin.DataSource = null; }
            else {  
               
                GridAdmin.DataSource = ebll.adminload(ename, estate);
                GridAdmin.Columns[6].Visible = false;
                
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpADD eadd = new EmpADD();
            eadd.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removefrm rm = new Removefrm();
            rm.ShowDialog();
        }

        private void issuedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueForm Is = new IssueForm();
            Is.ShowDialog();
        }

        private void receivedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiveForm RF = new ReceiveForm();
            RF.ShowDialog();

        }

        private void ordersExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainUI mi = new MainUI();
            mi.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Admin.SalaryForm sf = new SalaryForm();
            sf.ShowDialog();
        }

        private void AdProfileSetting_Click(object sender, EventArgs e)
        {
            Admin.AdSettingsPanel settingpanel = new AdSettingsPanel();
            settingpanel.adminName = td.Rows[0][1].ToString();
            settingpanel.AdminID = td.Rows[0][0].ToString();
            settingpanel.ShowDialog();
              
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime lbltime = DateTime.Now;
            lblTime.Text = lbltime.ToString( "hh:mm:ss: tt");
        }

        private void SalReport_Click(object sender, EventArgs e)
        {
            Reports.SalaryReport SalReport = new Reports.SalaryReport();
            SalReport.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            MailDeveloper mail = new MailDeveloper();
            mail.ShowDialog();
            
        }

        private void AdAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin addadminFrm = new AddAdmin();
            addadminFrm.ShowDialog();
        }

        private void BtnIssueOrder_Click(object sender, EventArgs e)
        {
            Reports.IssuedStock ISS = new Reports.IssuedStock();
            ISS.ShowDialog();
        }

        private void BtnReceiveOrder_Click(object sender, EventArgs e)
        {
            Reports.ReceiveStock RSBottle = new Reports.ReceiveStock();
            RSBottle.ShowDialog();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.AdSettingsPanel adp = new AdSettingsPanel();
            adp.ShowDialog();
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_us us = new About_us();
                us.ShowDialog();
        }

        private void mailDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailDeveloper mail = new MailDeveloper();
            mail.ShowDialog();
        }

        private void BtnEmpReport_Click(object sender, EventArgs e)
        {
            Reports.EmployeeReport Erp = new Reports.EmployeeReport();
                Erp.ShowDialog();
        }

        private void BtnEmpReport_Click_1(object sender, EventArgs e)
        {
            Reports.EmployeeReport emprep = new Reports.EmployeeReport();
            emprep.ShowDialog();
        }

        private void GridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void GridAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //  byte[] sunny = System.Text.Encoding.Unicode.GetBytes(GridAdmin.Rows[e.RowIndex].Cells[6].Value.ToString());
            
          
          //MemoryStream ms1 = new MemoryStream(sunny);
          //  ms1.Position = 0;

          //  pictureBox6.Image = new Bitmap(ms1);
        }
    }
    }
                         