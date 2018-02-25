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

namespace ItemManager.Admin
{
    public partial class Removefrm : MetroFramework.Forms.MetroForm

    {
        string id;
        empObjects obj = new empObjects();
        BLL.EmpDataBLL bll = new BLL.EmpDataBLL();
        DataGridViewButtonColumn dgButton = new DataGridViewButtonColumn();
     
        public Removefrm()
        {
            InitializeComponent();
        }
      
        public void Gridsearch()
        {
            //  string idd = id;
            //  obj.ID = id;
            //  string empName = txempName.Text;
            // string empDesign = txEmoDes.Text;
            // string empState = txEmpState.Text;
            //   string empQual = txEmpQual.Text;
            //   if (txempName.Text == string.Empty && txEmoDes.Text == string.Empty && txEmpState.Text == string.Empty && txEmpQual.Text == string.Empty && dgButton.Visible==false)
            ///    {
            //       rmGrid.DataSource = null;
            ///  }
            // else
            //  {
            //    rmGrid.DataSource = BLL.EmpDataBLL.rmSearch(idd,empName, empState, empDesign, empQual);


            //  rmGrid.Columns.Add(dgButton);

            /////  dgButton.HeaderText = "Delete";
            //   dgButton.Text = "Delete";
            //  dgButton.UseColumnTextForButtonValue = true;
            //                rmGrid.DataSource = null;
            try
            {
               
                rmGrid.Columns[0].Visible = false;
                rmGrid.Columns[1].HeaderText = "Employee Name";
                rmGrid.Columns[2].HeaderText = "State";
                rmGrid.Columns[3].HeaderText = "Designation";
                rmGrid.Columns[4].HeaderText = "Qualification";
               
                rmGrid.AutoGenerateColumns = false;



                rmGrid.Columns.Add(dgButton);

                dgButton.HeaderText = "Delete";
                dgButton.Text = "DELETE";
                dgButton.Name = "btn";
                dgButton.UseColumnTextForButtonValue = true;
            }
            catch (Exception)
            {
                return;
            }
        }


        private void txempName_TextChanged(object sender, EventArgs e)
        {
            string idd = id;
            obj.ID = id;
            string empName = txempName.Text;
            string empDesign = txEmoDes.Text;
            string empState = txEmpState.Text;
            string empQual = txEmpQual.Text;
            if (txempName.Text == string.Empty && txEmoDes.Text == string.Empty && txEmpState.Text == string.Empty && txEmpQual.Text == string.Empty  )
            {
                rmGrid.DataSource = null;
                dgButton.Visible = false;
            }
            else
            {
                rmGrid.DataSource = BLL.EmpDataBLL.rmSearch(idd, empName, empState, empDesign, empQual);
                rmGrid.Columns[0].Visible = false;
                rmGrid.AutoGenerateColumns = false;
                Gridsearch();
                rmGrid.DataSource = bll.Gload();
              

            }
        }

        private void rmGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = rmGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txEmoDes_TextChanged(object sender, EventArgs e)
        {
            string idd = id;
            obj.ID = id;
            string empName = txempName.Text;
            string empDesign = txEmoDes.Text;
            string empState = txEmpState.Text;
            string empQual = txEmpQual.Text;
            if (txempName.Text == string.Empty && txEmoDes.Text == string.Empty && txEmpState.Text == string.Empty && txEmpQual.Text == string.Empty && dgButton.Visible == false)
            {
                rmGrid.DataSource = null;
                dgButton.Visible = false;
            }
            else
            {
                rmGrid.DataSource = BLL.EmpDataBLL.rmSearch(idd, empName, empState, empDesign, empQual);
                rmGrid.Columns[0].Visible = false;
                rmGrid.AutoGenerateColumns = false;
                Gridsearch();
            }
        }
        private void txEmpState_TextChanged(object sender, EventArgs e)
        {
            string idd = id;
            obj.ID = id;
            string empName = txempName.Text;
            string empDesign = txEmoDes.Text;
            string empState = txEmpState.Text;
            string empQual = txEmpQual.Text;
            if (txempName.Text == string.Empty && txEmoDes.Text == string.Empty && txEmpState.Text == string.Empty && txEmpQual.Text == string.Empty && dgButton.Visible == false)
            {
                rmGrid.DataSource = null;
                dgButton.Visible = false;
            }
            else
            {
                rmGrid.DataSource = BLL.EmpDataBLL.rmSearch(idd, empName, empState, empDesign, empQual);
                rmGrid.Columns[0].Visible = false;
                rmGrid.AutoGenerateColumns = false;
                Gridsearch();
            }
        }

        private void txEmpQual_TextChanged(object sender, EventArgs e)
        {
            string idd = id;
            obj.ID = id;
            string empName = txempName.Text;
            string empDesign = txEmoDes.Text;
            string empState = txEmpState.Text;
            string empQual = txEmpQual.Text;
            if (txempName.Text == string.Empty && txEmoDes.Text == string.Empty && txEmpState.Text == string.Empty && txEmpQual.Text == string.Empty && dgButton.Visible == false)
            {
                rmGrid.DataSource = null;
            }
            else
            {
                rmGrid.DataSource = BLL.EmpDataBLL.rmSearch(idd, empName, empState, empDesign, empQual);
                rmGrid.Columns[0].Visible = false;
                rmGrid.AutoGenerateColumns = false;
                Gridsearch();
            }
        }

        
      
        private void rmGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                id = rmGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                empObjects obj = new empObjects();
                obj.ID = id;
                BLL.EmpDataBLL bllLayer = new BLL.EmpDataBLL();
                bllLayer.delEmp(id);
                MessageBox.Show("Data Deleted Sucessfully");
                rmGrid.DataSource = null;




            }
    }

        private void Removefrm_Load(object sender, EventArgs e)
        {
            GridAllign();
        }
         void GridAllign()
        {

     
            }
            

      
    }
    }



          
