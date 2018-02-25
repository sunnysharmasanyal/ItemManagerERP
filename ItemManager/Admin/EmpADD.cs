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
using System.IO;
using System.Text.RegularExpressions;

namespace ItemManager
{
    public partial class EmpADD : MetroFramework.Forms.MetroForm
    {
        public EmpADD()
        {
            InitializeComponent();
            obj.ID = id;
        }
        OpenFileDialog ndialog = new OpenFileDialog();
        DTO.empObjects obj = new empObjects();
        BLL.EmpDataBLL bll = new EmpDataBLL();


        public bool validation()
        {


            string strValidation = "";

            if (txName.Text == string.Empty)
            {
                strValidation = "Please fill the Name\n";
            }
            if (txAddress.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Address\n";
            }
            if (cmbState.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill State\n";
            }
            if (cmbDesignation.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Designation\n"; ;
            }
            if (txmail.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Email\n";
            }
            Regex exprr = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!exprr.IsMatch(txmail.Text))
            {
                strValidation = strValidation + "Please fill a valid Email Address\n";
            }
            if (txMobile.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill MobileNumber\n";
            }
            Regex expr = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (!expr.IsMatch(txMobile.Text))
            {
                strValidation = strValidation + "Please fill a valid Phone Number\n";
            }
            if (txtQual.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Qualification\n";
            }
            if (txUserName.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Qualification\n";
            }
            if (txPassword.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Qualification\n";
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



        public void btnSave_Click(object sender, EventArgs e)

        {
            if (validation() == true) 

                {
                    obj.name = txName.Text;
                    obj.Address = txAddress.Text;
                    obj.state = cmbState.Text;
                    obj.Desigination = cmbDesignation.Text;
                    obj.email = txmail.Text;
                    obj.mobilenumber = txMobile.Text;
                    obj.qualification = txtQual.Text;
                    obj.username = txUserName.Text;
                    obj.password = txPassword.Text;
                    if (this.txmail.Text.Contains('@') == false || this.txmail.Text.Contains('.') == false) { MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (this.txMobile.Text.Length < 10 || this.txMobile.Text.Length > 10) { MessageBox.Show("Please Enter A Valid 10 Digit Mobile Number", "Invalid Mobile", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (this.txName == this.txUserName) { MessageBox.Show("Username & Name must be Different"); }
                    //code for storing Image to Database //

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray(pi);
                    EmpDataBLL eDB = new EmpDataBLL();
                    eDB.empDataAdd(obj, pic);
                    EmpAddGrid.DataSource = bll.Gload();
                    MessageBox.Show("sucess Employee Entered ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDesignation.DataSource= null;
                    cmbState.DataSource = null;
                    clear();
                }
                else
                {
                    
                }

            

        }






        public void clear()
        {
            txName.Clear();
            txAddress.Clear();

            txmail.Clear();
            txMobile.Clear();
            txtQual.Clear();
            pictureBox1.Image = null;
            txUserName.Clear();
            txPassword.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {


            this.Hide();
        }

        private void EmpADD_Load(object sender, EventArgs e)
        {
            EmpAddGrid.DataSource = bll.Gload();
            EmpAddGrid.Columns[0].Visible = false;
            EmpAddGrid.Columns[1].HeaderText = "EmployeeName";
            EmpAddGrid.Columns[2].HeaderText = "Address";
            EmpAddGrid.Columns[3].HeaderText = "State";
            EmpAddGrid.Columns[4].HeaderText = "Designation";
            EmpAddGrid.Columns[5].HeaderText = "Email";
            EmpAddGrid.Columns[6].HeaderText = "Mobile Number";
            EmpAddGrid.Columns[7].HeaderText = "Qualification";
            EmpAddGrid.Columns[8].HeaderText = "UserName";
            EmpAddGrid.Columns[9].HeaderText = "Password";
            EmpAddGrid.Columns[10].Visible = false;

            EmpAddGrid.AutoGenerateColumns = false;
            fillCombo();
        }

        public void fillCombo()
        {


            cmbDesignation.DataSource = bll.cmbValuefill();
            cmbDesignation.DisplayMember = "Grade";
            cmbDesignation.DataBindings.ToString();




        }
        string id;
        private void EmpAddGrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = EmpAddGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txName.Text = EmpAddGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txAddress.Text = EmpAddGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbState.Text = EmpAddGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDesignation.Text = EmpAddGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txmail.Text = EmpAddGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txMobile.Text = EmpAddGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtQual.Text = EmpAddGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            txUserName.Text = EmpAddGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            txPassword.Text = EmpAddGrid.Rows[e.RowIndex].Cells[9].Value.ToString();

            EmpAddGrid.AutoGenerateColumns = false;
            btnSave.Enabled = false;

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if ( validation()== true) { 
                
            
            
                obj.name = txName.Text;
                obj.Address = txAddress.Text;
                obj.state = cmbState.Text;
                obj.Desigination = cmbDesignation.Text;
            obj.email = txmail.Text;
            obj.mobilenumber = txMobile.Text;
            obj.qualification = txtQual.Text;
            obj.username = txUserName.Text;
            obj.password = txPassword.Text;

            obj.ID = id;
            if (obj.ID == id)                                  
            {
                bll.update(obj);

                EmpAddGrid.DataSource = bll.Gload();
                    MessageBox.Show("Update Sucess");
                    }
                }
           
            }
        

        private void BtnBrowse_Click(object sender, EventArgs e)
        {

            if (validation() == true)
            {

                ndialog.Filter = "Images | *.jpg;*.png";

                DialogResult dr = ndialog.ShowDialog();
                if (dr == DialogResult.Abort)
                    return;
                if (dr == DialogResult.Cancel)
                    return;

                pictureBox1.Image = Image.FromFile(ndialog.FileName);

            }

        }
    }
}


