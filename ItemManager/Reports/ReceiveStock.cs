using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemManager.Reports
{
    public partial class ReceiveStock : Form
    {
        public ReceiveStock()
        {
            InitializeComponent();
        }

        private void ReceiveStock_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (InventoryManagementEntities db = new InventoryManagementEntities())
            {
                GetReceieveReport_ResultBindingSource.DataSource = db.GetReceieveReport(dtFromDateReceive.Value, dtToDateReceive.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("FromDate",dtFromDateReceive.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("ToDate",dtToDateReceive.Value.Date.ToShortDateString())
                };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }
        }
    }
}
