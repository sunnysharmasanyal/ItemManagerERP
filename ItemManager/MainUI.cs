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
namespace ItemManager
{
    public partial class MainUI :MetroFramework.Forms.MetroForm

    {
        EmpDataBLL ebll = new EmpDataBLL();
        empObjects eobj = new empObjects();
        DataTable td = new DataTable();
        Settings st = new Settings();
        
       
        public MainUI()
        {

            InitializeComponent();
            

        }



      
        public void   UserNFetch(string myname)
        {
             UName.Text=myname;
            st.newname(myname);
            
            //ItemManagerUI ui = new ItemManagerUI();
            //ui.newm(myname);
               

        }
        public void MainUI_Load(object sender, EventArgs e )
        {
          
            DateTime.Text = System.DateTime.Now.ToLongDateString();
            td= ebll.LoginBLL(eobj);
          


        }








    private void ExportToExel_Click(object sender, EventArgs e)
        {      
        }

     

        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin.LoginPannel lg = new Admin.LoginPannel();
            lg.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin.LoginPannel lp = new Admin.LoginPannel();
            lp.Show();
            
           
        }

        
          

       

       

       

        private void dashBtn_Click(object sender, EventArgs e)
        {
            ItemManagerUI AddRemUpd = new ItemManagerUI();
            AddRemUpd.Show();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueForm IsForm = new ItemManager.IssueForm();
            IsForm.Show();
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            ReceiveForm RF = new ItemManager.ReceiveForm();
            RF.Show();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            EmpADD eDetail = new EmpADD();
            eDetail.Show();
        
    }

        private void Search_Click(object sender, EventArgs e)
        {
            string type = txttype.Text;
            string color = txtcolor.Text;
            string location = txtloc.Text;
            mainUIDataGridView.DataSource = BLL.BLL.Msearch(type, color, location);
            mainUIDataGridView.DefaultCellStyle.Font = new Font("Arial", 13.00f, FontStyle.Regular);
            mainUIDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13.00f, FontStyle.Regular);
            mainUIDataGridView.Columns[0].HeaderText = "Item Description";
            //mainUIDataGridView.Columns[1].Visible = false;
            {
                mainUIDataGridView.Columns[2].HeaderText = "Date";
                mainUIDataGridView.Columns[1].HeaderText = "Quantity";
                mainUIDataGridView.AutoGenerateColumns = false;
                if (mainUIDataGridView.Rows.Count == 1)
                    MessageBox.Show(" No Inventory Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
           st.Show();
           

          
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ExportToExel_Click_1(object sender, EventArgs e)
        {
            //creating the application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new excel workbook with excel app
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //creating new excel sheet in worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //see the excel behind the program
            app.Visible = true;
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "InventoryManagementSheet";
            //storing header part in excel
            for (int i = 0; i < mainUIDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[i + 1] = mainUIDataGridView.Columns[i].HeaderText;

            }


            // storing Each row and column value to excel sheet 
            for (int i = 0; i < mainUIDataGridView.Rows.Count; i++)

            {

                for (int j = 0; j < mainUIDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = mainUIDataGridView.Rows[i].Cells[j].Value.ToString();

                }
            }

            // Exit from the application 
            app.Quit();
        }
    }
    }
   
                                                                