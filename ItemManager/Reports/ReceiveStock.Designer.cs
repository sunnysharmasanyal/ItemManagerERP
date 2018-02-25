namespace ItemManager.Reports
{
    partial class ReceiveStock
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
            this.GetReceieveReport_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtToDateReceive = new System.Windows.Forms.DateTimePicker();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.dtFromDateReceive = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GetReceieveReport_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtToDateReceive
            // 
            this.dtToDateReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDateReceive.Location = new System.Drawing.Point(313, 9);
            this.dtToDateReceive.Name = "dtToDateReceive";
            this.dtToDateReceive.Size = new System.Drawing.Size(130, 20);
            this.dtToDateReceive.TabIndex = 7;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(475, 6);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "&Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dtFromDateReceive
            // 
            this.dtFromDateReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDateReceive.Location = new System.Drawing.Point(100, 6);
            this.dtFromDateReceive.Name = "dtFromDateReceive";
            this.dtFromDateReceive.Size = new System.Drawing.Size(132, 20);
            this.dtFromDateReceive.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "From date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From date";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReceiveStock";
            reportDataSource1.Value = this.GetReceieveReport_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ItemManager.Reports.ReceiveStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(607, 374);
            this.reportViewer1.TabIndex = 10;
            // 
            // ReceiveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 453);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtToDateReceive);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.dtFromDateReceive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReceiveStock";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiveStock";
            this.Load += new System.EventHandler(this.ReceiveStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetReceieveReport_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtToDateReceive;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DateTimePicker dtFromDateReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetReceieveReport_ResultBindingSource;
    }
}