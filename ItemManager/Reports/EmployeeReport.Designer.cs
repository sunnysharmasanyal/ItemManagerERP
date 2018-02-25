namespace ItemManager.Reports
{
    partial class EmployeeReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryManagementEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryManagementDataSet1 = new ItemManager.InventoryManagementDataSet1();
            this.inventoryManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeeReportTableAdapter = new ItemManager.InventoryManagementDataSet1TableAdapters.GetEmployeeReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getEmployeeReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ItemManager.Reports.EmployeeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(376, 11);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(130, 20);
            this.dtToDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "To date";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(541, 8);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 12;
            this.BtnLoad.Text = "&Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(147, 11);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(132, 20);
            this.dtFromDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "From date";
            // 
            // inventoryManagementEntitiesBindingSource
            // 
            this.inventoryManagementEntitiesBindingSource.DataSource = typeof(ItemManager.Reports.InventoryManagementEntities);
            // 
            // employeeReportBindingSource
            // 
            this.employeeReportBindingSource.DataSource = typeof(ItemManager.Reports.EmployeeReport);
            // 
            // inventoryManagementDataSet1
            // 
            this.inventoryManagementDataSet1.DataSetName = "InventoryManagementDataSet1";
            this.inventoryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryManagementDataSet1BindingSource
            // 
            this.inventoryManagementDataSet1BindingSource.DataSource = this.inventoryManagementDataSet1;
            this.inventoryManagementDataSet1BindingSource.Position = 0;
            // 
            // getEmployeeReportBindingSource
            // 
            this.getEmployeeReportBindingSource.DataMember = "GetEmployeeReport";
            this.getEmployeeReportBindingSource.DataSource = this.inventoryManagementDataSet1BindingSource;
            // 
            // getEmployeeReportTableAdapter
            // 
            this.getEmployeeReportTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 360);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeReport";
            this.Text = "EmployeeReport";
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryManagementDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource inventoryManagementEntitiesBindingSource;
        private System.Windows.Forms.BindingSource employeeReportBindingSource;
        private System.Windows.Forms.BindingSource getEmployeeReportBindingSource;
        private System.Windows.Forms.BindingSource inventoryManagementDataSet1BindingSource;
        private InventoryManagementDataSet1 inventoryManagementDataSet1;
        private InventoryManagementDataSet1TableAdapters.GetEmployeeReportTableAdapter getEmployeeReportTableAdapter;
    }
}