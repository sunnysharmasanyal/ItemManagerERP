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
using System.Data.SqlClient;

namespace ItemManager.Admin
{
    public partial class SalaryForm : MetroFramework.Forms.MetroForm
    {
     public static   SqlDataReader dr;
        public SalaryForm()
        {
            InitializeComponent();
        }
        EmpDataBLL blllayer = new EmpDataBLL();
       
        public void fillCombo()
        {
            
           
            cmbEmpGrade.DataSource = blllayer.cmbValuefill();
            cmbEmpGrade.DisplayMember = "Grade";
            cmbEmpGrade.DataBindings.ToString();




        }
         public void empnamefill()
        {
            EmpName.DataSource = blllayer.cmbEmpValueFill();
            EmpName.DisplayMember = "name";
            EmpName.DataBindings.ToString();
        }
        private void SalaryForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            empnamefill();

        }

        

        

        private void cmbEmpGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable td = new DataTable();


            object selectedVal = this.cmbEmpGrade.GetItemText(this.cmbEmpGrade.SelectedItem);

            td = blllayer.reqValMethod(selectedVal);
            basicSalary.DataBindings.Clear();
            basicSalary.DataBindings.Add("Text", td, "basicSalary");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {     // Method by sunny


            if (xhkboxPFDeduction.Checked == false && txtTotalLeaves.Text == string.Empty  ) { MessageBox.Show("PF must be Selected"); } 
            else { 
            string employeeName = EmpName.Text;
            string empGrade = cmbEmpGrade.Text;
            int basicsal = Int32.Parse( basicSalary.Text);
            int leaves = Int32.Parse(txtTotalLeaves.Text);
            int ttSalary = 0;
            int Benifits=0;
                
           if(chkboxHouseAllow.Checked)
            {
                Benifits = Benifits + 3000;
            }
           if(chkboxConvenceAllowances.Checked)
            { Benifits = Benifits + 500; }
           if(chkboxHospitalAllowance.Checked)
            {
                Benifits = Benifits + 1000;

            }
           if(chkboxOtherBenifits.Checked)
            {
                Benifits = Benifits + 500;
               
            }
           else
            {
                
            }
            basicsal = basicsal + Benifits;
            int totalDeduction = 0;
            if (chkboxMedicalDed.Checked)
            {
                totalDeduction = 500;
                basicsal =  basicsal- totalDeduction;
            }
            if (xhkboxPFDeduction.Checked)
            {
                int pfDeduction = 1000;
                basicsal = basicsal - pfDeduction;
                totalDeduction = pfDeduction + totalDeduction;
            }   

           

           if(System.Text.RegularExpressions.Regex.IsMatch(txtTotalLeaves.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtTotalLeaves.Text = txtTotalLeaves.Text.Remove(txtTotalLeaves.Text.Length - 1);
            }
            ttSalary = basicsal / 30 ;
            int presents =  30- leaves;
            int totalSalary = ttSalary * presents;
            int roundedsalary = totalSalary;
            txtSalary.Text += roundedsalary;
            BLL.EmpDataBLL.empSalary(employeeName,empGrade,basicsal,Benifits,totalDeduction,roundedsalary);
            MessageBox.Show("Salary Updated", "Salary Information", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkboxHouseAllow.Checked = false;
            chkboxMedicalDed.Checked = false;
            chkboxConvenceAllowances.Checked = false;
            chkboxOtherBenifits.Checked = false;
            chkboxHospitalAllowance.Checked = false;
            xhkboxPFDeduction.Checked = false;
            txtTotalLeaves.Text = string.Empty;
            txtSalary.Text = string.Empty;

        }
    }
}
                                       