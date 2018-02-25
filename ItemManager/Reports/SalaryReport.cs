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
    public partial class SalaryReport : Form
    {
        public SalaryReport()
        {
            InitializeComponent();
        }

        private void SalaryReport_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (InventoryManagementEntities db = new InventoryManagementEntities())
            {   
                GetSalaryReport_ResultBindingSource.DataSource = db.GetSalaryReport(dtFromDate.Value, dtToDate.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("FromDate",dtFromDate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("ToDate",dtToDate.Value.Date.ToShortDateString())
                };
                reportViewer.LocalReport.SetParameters(rParams);
                reportViewer.RefreshReport();
            }
        }
    }
}
