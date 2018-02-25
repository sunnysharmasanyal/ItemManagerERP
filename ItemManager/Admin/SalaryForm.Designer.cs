namespace ItemManager.Admin
{
    partial class SalaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpGrade = new System.Windows.Forms.ComboBox();
            this.chkboxHouseAllow = new System.Windows.Forms.CheckBox();
            this.chkboxConvenceAllowances = new System.Windows.Forms.CheckBox();
            this.chkboxHospitalAllowance = new System.Windows.Forms.CheckBox();
            this.chkboxOtherBenifits = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkboxMedicalDed = new System.Windows.Forms.CheckBox();
            this.txtTotalLeaves = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.xhkboxPFDeduction = new System.Windows.Forms.CheckBox();
            this.basicSalary = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Benifits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Salary";
            // 
            // cmbEmpGrade
            // 
            this.cmbEmpGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpGrade.FormattingEnabled = true;
            this.cmbEmpGrade.Location = new System.Drawing.Point(236, 165);
            this.cmbEmpGrade.Name = "cmbEmpGrade";
            this.cmbEmpGrade.Size = new System.Drawing.Size(198, 28);
            this.cmbEmpGrade.TabIndex = 7;
            this.cmbEmpGrade.SelectedIndexChanged += new System.EventHandler(this.cmbEmpGrade_SelectedIndexChanged);
            // 
            // chkboxHouseAllow
            // 
            this.chkboxHouseAllow.AutoSize = true;
            this.chkboxHouseAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHouseAllow.Location = new System.Drawing.Point(139, 17);
            this.chkboxHouseAllow.Name = "chkboxHouseAllow";
            this.chkboxHouseAllow.Size = new System.Drawing.Size(139, 20);
            this.chkboxHouseAllow.TabIndex = 9;
            this.chkboxHouseAllow.Text = "House Allowances";
            this.chkboxHouseAllow.UseVisualStyleBackColor = true;
            // 
            // chkboxConvenceAllowances
            // 
            this.chkboxConvenceAllowances.AutoSize = true;
            this.chkboxConvenceAllowances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxConvenceAllowances.Location = new System.Drawing.Point(287, 17);
            this.chkboxConvenceAllowances.Name = "chkboxConvenceAllowances";
            this.chkboxConvenceAllowances.Size = new System.Drawing.Size(160, 20);
            this.chkboxConvenceAllowances.TabIndex = 10;
            this.chkboxConvenceAllowances.Text = "Convence Allowances";
            this.chkboxConvenceAllowances.UseVisualStyleBackColor = true;
            // 
            // chkboxHospitalAllowance
            // 
            this.chkboxHospitalAllowance.AutoSize = true;
            this.chkboxHospitalAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxHospitalAllowance.Location = new System.Drawing.Point(136, 55);
            this.chkboxHospitalAllowance.Name = "chkboxHospitalAllowance";
            this.chkboxHospitalAllowance.Size = new System.Drawing.Size(142, 20);
            this.chkboxHospitalAllowance.TabIndex = 11;
            this.chkboxHospitalAllowance.Text = "Hospital Allowance";
            this.chkboxHospitalAllowance.UseVisualStyleBackColor = true;
            // 
            // chkboxOtherBenifits
            // 
            this.chkboxOtherBenifits.AutoSize = true;
            this.chkboxOtherBenifits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxOtherBenifits.Location = new System.Drawing.Point(287, 55);
            this.chkboxOtherBenifits.Name = "chkboxOtherBenifits";
            this.chkboxOtherBenifits.Size = new System.Drawing.Size(110, 20);
            this.chkboxOtherBenifits.TabIndex = 12;
            this.chkboxOtherBenifits.Text = "Other Benefits";
            this.chkboxOtherBenifits.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(83, 472);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 28);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(238, 529);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(177, 26);
            this.txtSalary.TabIndex = 16;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chkboxOtherBenifits);
            this.metroPanel1.Controls.Add(this.chkboxHospitalAllowance);
            this.metroPanel1.Controls.Add(this.chkboxConvenceAllowances);
            this.metroPanel1.Controls.Add(this.chkboxHouseAllow);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 271);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(486, 98);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Deductions";
            // 
            // chkboxMedicalDed
            // 
            this.chkboxMedicalDed.AutoSize = true;
            this.chkboxMedicalDed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxMedicalDed.Location = new System.Drawing.Point(138, 6);
            this.chkboxMedicalDed.Name = "chkboxMedicalDed";
            this.chkboxMedicalDed.Size = new System.Drawing.Size(139, 20);
            this.chkboxMedicalDed.TabIndex = 13;
            this.chkboxMedicalDed.Text = "Medical Deduction";
            this.chkboxMedicalDed.UseVisualStyleBackColor = true;
            // 
            // txtTotalLeaves
            // 
            this.txtTotalLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLeaves.Location = new System.Drawing.Point(232, 46);
            this.txtTotalLeaves.Name = "txtTotalLeaves";
            this.txtTotalLeaves.Size = new System.Drawing.Size(177, 26);
            this.txtTotalLeaves.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Leaves";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.xhkboxPFDeduction);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.Controls.Add(this.txtTotalLeaves);
            this.metroPanel2.Controls.Add(this.chkboxMedicalDed);
            this.metroPanel2.Controls.Add(this.label5);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(4, 375);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(486, 91);
            this.metroPanel2.TabIndex = 21;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // xhkboxPFDeduction
            // 
            this.xhkboxPFDeduction.AutoSize = true;
            this.xhkboxPFDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xhkboxPFDeduction.Location = new System.Drawing.Point(288, 6);
            this.xhkboxPFDeduction.Name = "xhkboxPFDeduction";
            this.xhkboxPFDeduction.Size = new System.Drawing.Size(191, 20);
            this.xhkboxPFDeduction.TabIndex = 21;
            this.xhkboxPFDeduction.Text = "Provisional Fund Deduciton";
            this.xhkboxPFDeduction.UseVisualStyleBackColor = true;
            // 
            // basicSalary
            // 
            this.basicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSalary.Location = new System.Drawing.Point(238, 218);
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.Size = new System.Drawing.Size(177, 26);
            this.basicSalary.TabIndex = 22;
            // 
            // EmpName
            // 
            this.EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.FormattingEnabled = true;
            this.EmpName.Location = new System.Drawing.Point(236, 113);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(198, 28);
            this.EmpName.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.basicSalary);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbEmpGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "SalaryForm";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEmpGrade;
        private System.Windows.Forms.CheckBox chkboxHouseAllow;
        private System.Windows.Forms.CheckBox chkboxConvenceAllowances;
        private System.Windows.Forms.CheckBox chkboxHospitalAllowance;
        private System.Windows.Forms.CheckBox chkboxOtherBenifits;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSalary;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkboxMedicalDed;
        private System.Windows.Forms.TextBox txtTotalLeaves;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.CheckBox xhkboxPFDeduction;
        private System.Windows.Forms.TextBox basicSalary;
        private System.Windows.Forms.ComboBox EmpName;
        private System.Windows.Forms.Button button1;
    }
}