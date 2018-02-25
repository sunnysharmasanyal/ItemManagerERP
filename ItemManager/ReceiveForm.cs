using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemManager
{
    public partial class ReceiveForm : MetroFramework.Forms.MetroForm
    {
        public ReceiveForm()
        {
            InitializeComponent();
        }
        string id = "";

        private void dGridReceiveForm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try { 
            id = dGridReceiveForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            string type = dGridReceiveForm.Rows[e.RowIndex].Cells[1].Value.ToString();
            string count = dGridReceiveForm.Rows[e.RowIndex].Cells[2].Value.ToString();
            string color = dGridReceiveForm.Rows[e.RowIndex].Cells[4].Value.ToString();
            txItmName.Text = (type + " " + count + " " + color);
            txItemWeight.Enabled = true;
            }
            catch (Exception) { return; }
        }
        
            private void btnReceive_Click_1(object sender, EventArgs e)
        {
            string Rweight = txItemWeight.Text;
            string Rid = id;
            BLL.BLL.receive(Rweight, Rid);
            if (txItemWeight.Enabled == false)
            {
                MessageBox.Show("Please Select an entry", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txItemWeight.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {


                MessageBox.Show("Successfully Received", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                txItemWeight.Text = "";
               dGridReceiveForm.DataSource= BLL.BLL.DirectSearch();
            }
        }

        private void txType_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
           dGridReceiveForm.DataSource= BLL.BLL.search(type, color, location);
            dGridReceiveForm.Columns[0].Visible = false;

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
            dGridReceiveForm.DataSource = BLL.BLL.search(type, color, location);
            dGridReceiveForm.Columns[0].Visible = false;


        }

        private void txLoc_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
            dGridReceiveForm.DataSource = BLL.BLL.search(type, color, location);
            dGridReceiveForm.Columns[0].Visible = false;

        }

        private void ReceiveForm_Load(object sender, EventArgs e)
        {
            txItmName.Enabled = false;
            txItemWeight.Enabled = false;
        }
    }
}
