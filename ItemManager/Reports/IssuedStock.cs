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
    public partial class IssuedStock : Form
    {
        public IssuedStock()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (InventoryManagementEntities db = new InventoryManagementEntities())
            {
                getIssuedReportBindingSource.DataSource = db.GetIssuedReport(dtFromDate.Value, dtToDate.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParam = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                 new Microsoft.Reporting.WinForms.ReportParameter("FromDate", dtFromDate.Value.Date.ToShortDateString()) ,
                 new Microsoft.Reporting.WinForms.ReportParameter("ToDate",dtToDate.Value.Date.ToShortDateString())
                

                };
                reportViewer.LocalReport.SetParameters(rParam);
                reportViewer.RefreshReport();
            }
        }
                                                                
        private void IssuedStock_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }
    }
}
