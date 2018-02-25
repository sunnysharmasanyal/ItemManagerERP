namespace ItemManager.Reports
{
    partial class IssuedStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getIssuedReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagementDataSet = new ItemManager.InventoryManagementDataSet();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getIssuedReportTableAdapter = new ItemManager.InventoryManagementDataSetTableAdapters.GetIssuedReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getIssuedReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getIssuedReportBindingSource
            // 
            this.getIssuedReportBindingSource.DataMember = "GetIssuedReport";
            this.getIssuedReportBindingSource.DataSource = this.inventoryManagementDataSet;
            // 
            // inventoryManagementDataSet
            // 
            this.inventoryManagementDataSet.DataSetName = "InventoryManagementDataSet";
            this.inventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(384, 12);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(130, 20);
            this.dtToDate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To date";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(549, 9);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 7;
            this.BtnLoad.Text = "&Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(155, 12);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(132, 20);
            this.dtFromDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From date";
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "IssuedStock";
            reportDataSource1.Value = this.getIssuedReportBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ItemManager.Reports.IssuedStock.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(4, 49);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(793, 394);
            this.reportViewer.TabIndex = 10;
            // 
            // getIssuedReportTableAdapter
            // 
            this.getIssuedReportTableAdapter.ClearBeforeFill = true;
            // 
            // IssuedStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 455);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label1);
            this.Name = "IssuedStock";
            this.Text = "IssuedStock";
            this.Load += new System.EventHandler(this.IssuedStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getIssuedReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource getIssuedReportBindingSource;
        private InventoryManagementDataSet inventoryManagementDataSet;
        private InventoryManagementDataSetTableAdapters.GetIssuedReportTableAdapter getIssuedReportTableAdapter;
    }
}