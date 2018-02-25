using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ItemManager.DTO;
using ItemManager.BLL;
using System.Data.SqlClient;
using System.Data;

namespace ItemManager

{
    public partial class ItemManagerUI : MetroFramework.Forms.MetroForm

    {

        public ItemManagerUI()
        {
            InitializeComponent();
        }
        DataGridViewButtonColumn dgButton = new DataGridViewButtonColumn();
        string id = "";
        //creating object and then accessing the DTO Properties
        public bool validationFeilds()
        {
            string strValidation = "";

            if (txtItmType.Text == string.Empty)
            {
                strValidation = "Please fill the Type\n";
            }
            if (txtItmCount.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Count\n";
            }
            if (txtItmLno.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill LotNo\n";
            }
            if (cmbItmColor.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill Colour\n"; ;
            }
            if (txtItmWeight.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill weight\n";
            }
            if (txtItmLoc.Text == string.Empty)
            {
                strValidation = strValidation + "Please fill location\n";
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
               string neww ;
        public void newm(string id)
        {
          neww = id;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validationFeilds() == true)
            {

                Objects obj = new Objects();
                if (id == "")
                {
                    
                    obj.type = txtItmType.Text;
                    obj.count = txtItmCount.Text;
                    obj.color = cmbItmColor.Text;
                    obj.lotno = int.Parse(txtItmLno.Text);
                    obj.weight = txtItmWeight.Text;
                    obj.location = txtItmLoc.Text;
                    BLL.BLL.GetVal(obj);
                    btn_save.Text = "Inserted";
                    MessageBox.Show("Data Inserted Sucessfully");
                }
                else
                   
                {
                    obj.id = id;
                    
                    obj.type = txtItmType.Text;
                    obj.count = txtItmCount.Text;
                    obj.color = cmbItmColor.Text;
                    obj.lotno = int.Parse(txtItmLno.Text);
                    obj.weight = txtItmWeight.Text;
                    obj.location = txtItmLoc.Text;
                    BLL.BLL.GetVal(obj);
                    btn_save.Text = "Updated";
                    MessageBox.Show("Data Updated Sucessfully");
                    id = "";
                }
                // sending the objects instances to the BLL Layer Method as Parameter

                dataGridView1.DataSource = BLL.BLL.Valget();
                clear();

            }

        }
        public void clear()
        {
            txtItmType.Clear();
            txtItmCount.Clear();
            txtItmLno.Clear();
            txtItmWeight.Clear();
            txtItmLoc.Clear();
            txtItmType.Focus();
            cmbItmColor.Clear();
        }
        // Displaying the Grid To show Data
        private void ItemManagerUI_Load(object sender, EventArgs e)
        {
            gridDesign();
            btn_save.Text = "Save";
            Glbl.Text = neww;
            Glbl.Visible = true;
        }
        public void gridDesign()
        {
            try
            {          
                //    dataGridView1.DataSource = BLL.BLL.Valget();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Type";
            dataGridView1.Columns[2].HeaderText = "Count";
            dataGridView1.Columns[3].HeaderText = "Lot-No";
            dataGridView1.Columns[4].HeaderText = "Color";
            dataGridView1.Columns[5].HeaderText = "Weight";
            dataGridView1.Columns[6].HeaderText = "Location";
            dataGridView1.AutoGenerateColumns = false;
           
            
              
            dataGridView1.Columns.Add(dgButton);

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





        // Displaying the Grid To show Data


        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           try { 
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItmType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItmCount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtItmLno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbItmColor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtItmWeight.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtItmLoc.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtItmWeight.Enabled = false;
            btn_save.Text = "UpdateRecord";
            dataGridView1.AutoGenerateColumns = false;
               
            }
            catch(Exception)
            {

                return;
            }



        }

        
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idd;
            if (e.ColumnIndex == 7)
                
            {
                idd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Objects obj = new Objects();
                obj.id = idd;



                BLL.BLL del = new BLL.BLL();

                del.getDelete(obj);
                MessageBox.Show("Data Deleted Sucessfully");
                dataGridView1.DataSource = BLL.BLL.Valget();
                clear();
            }
        }

        private void txtItmType_TextChanged(object sender, EventArgs e)
        {
            string newQuery,color;
           string  location;
            
            location = txtItmLoc.Text;
            color = cmbItmColor.Text;
            newQuery = txtItmType.Text;
       

            dataGridView1.DataSource = BLL.BLL.search(newQuery,color, location);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            gridDesign();
            gridvalidate();
           
        }



        private void cmbItmColor_TextChanged(object sender, EventArgs e)
        {
            string colorQuery;
            string type;
            string location;
            location = txtItmLoc.Text;
            type = txtItmType.Text;
            colorQuery = cmbItmColor.Text;
            dataGridView1.DataSource = BLL.BLL.search(type, colorQuery ,location);
            dataGridView1.Columns[0].Visible = false;
            gridvalidate();
        }

        private void txtItmLoc_TextChanged(object sender, EventArgs e)
        {
            string location;
            string type, Color;
            type = txtItmType.Text;
            Color = cmbItmColor.Text;
            location = txtItmLoc.Text;
            dataGridView1.DataSource = BLL.BLL.search(type, Color, location);
            gridvalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            txtItmWeight.Enabled = true;
            dataGridView1.DataSource = null;
            //if (txtItmType.Text==string.Empty && txtItmWeight.Text == string.Empty && txtItmLoc.Text == string.Empty && txtItmCount.Text == string.Empty && txtItmLno.Text==string.Empty && cmbItmColor.Text == string.Empty)
            //{ dataGridView1.DataSource = null; }
        }
        public void  gridvalidate() {
            if (txtItmType.Text == string.Empty && txtItmLoc.Text == string.Empty && txtItmCount.Text == string.Empty && txtItmLno.Text == string.Empty && cmbItmColor.Text == string.Empty)
            {
                txtItmWeight.Text = "";
                txtItmWeight.Enabled = true;
                btn_save.Text = "Insert Record";
                dataGridView1.DataSource = null;

            }
        }
    }
    }
    



            
        

    

    
                                  