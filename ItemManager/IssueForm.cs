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

namespace ItemManager
{
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        string id = "";

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
            dGridIssueForm.DataSource = BLL.BLL.search(type, color, location);
            dGridIssueForm.Columns[0].Visible = false;
            validation();
        }

       
        private void txType_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
            dGridIssueForm.DataSource = BLL.BLL.search(type, color, location);
            dGridIssueForm.Columns[0].Visible = false;
            validation();

        }

        private void txLoc_TextChanged(object sender, EventArgs e)
        {
            string type = txType.Text;
            string color = txtColor.Text;
            string location = txLoc.Text;
            dGridIssueForm.DataSource = BLL.BLL.search(type, color, location);
            dGridIssueForm.Columns[0].Visible = false;
            validation();
        }

        private void dGridIssueForm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = dGridIssueForm.Rows[e.RowIndex].Cells[0].Value.ToString();
                string type = dGridIssueForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                string count = dGridIssueForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                string color = dGridIssueForm.Rows[e.RowIndex].Cells[4].Value.ToString();
                txItmName.Text = (type + " " + count + " " + color);
                string Name = txItmName.Text;
                txItemWeight.Enabled = true;
            }
            catch (Exception) { return; }



        }

        private void IssueForm_Load(object sender, EventArgs e)
        {
            txItemWeight.Enabled = false;
            txItmName.Enabled = false;


        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            string weight = txItemWeight.Text;

            string idd = id;
            BLL.BLL.IssueData(weight, id);
            if (txItemWeight.Enabled == false)
            {
                MessageBox.Show("Please Select an entry", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(txItemWeight.Text == string.Empty)
                {
                MessageBox.Show("Please Enter The Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            else
            {


                MessageBox.Show("Successfully Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                txItemWeight.Text = "";
                dGridIssueForm.DataSource = BLL.BLL.DirectSearch();
            }
        }
        void validation() { if (txtColor.Text==string.Empty&& txType.Text == string.Empty && txLoc.Text == string.Empty) { txItmName.Text = ""; } }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txItemWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {

        }
    }
}
