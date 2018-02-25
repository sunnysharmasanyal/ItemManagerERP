namespace ItemManager.Admin
{
    partial class Removefrm
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
            this.txempName = new System.Windows.Forms.TextBox();
            this.txEmpQual = new System.Windows.Forms.TextBox();
            this.txEmoDes = new System.Windows.Forms.TextBox();
            this.txEmpState = new System.Windows.Forms.TextBox();
            this.rmGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rmGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qualification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // txempName
            // 
            this.txempName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txempName.Location = new System.Drawing.Point(204, 86);
            this.txempName.Name = "txempName";
            this.txempName.Size = new System.Drawing.Size(166, 26);
            this.txempName.TabIndex = 1;
            this.txempName.TextChanged += new System.EventHandler(this.txempName_TextChanged);
            // 
            // txEmpQual
            // 
            this.txEmpQual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmpQual.Location = new System.Drawing.Point(549, 149);
            this.txEmpQual.Name = "txEmpQual";
            this.txEmpQual.Size = new System.Drawing.Size(172, 26);
            this.txEmpQual.TabIndex = 4;
            this.txEmpQual.TextChanged += new System.EventHandler(this.txEmpQual_TextChanged);
            // 
            // txEmoDes
            // 
            this.txEmoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmoDes.Location = new System.Drawing.Point(549, 89);
            this.txEmoDes.Name = "txEmoDes";
            this.txEmoDes.Size = new System.Drawing.Size(172, 26);
            this.txEmoDes.TabIndex = 2;
            this.txEmoDes.TextChanged += new System.EventHandler(this.txEmoDes_TextChanged);
            // 
            // txEmpState
            // 
            this.txEmpState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmpState.Location = new System.Drawing.Point(204, 149);
            this.txEmpState.Name = "txEmpState";
            this.txEmpState.Size = new System.Drawing.Size(166, 26);
            this.txEmpState.TabIndex = 3;
            this.txEmpState.TextChanged += new System.EventHandler(this.txEmpState_TextChanged);
            // 
            // rmGrid
            // 
            this.rmGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rmGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rmGrid.Location = new System.Drawing.Point(63, 213);
            this.rmGrid.Name = "rmGrid";
            this.rmGrid.Size = new System.Drawing.Size(658, 114);
            this.rmGrid.TabIndex = 8;
            this.rmGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rmGrid_CellContentClick);
            this.rmGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rmGrid_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 49);
            this.panel2.TabIndex = 13;
            // 
            // Removefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rmGrid);
            this.Controls.Add(this.txEmpState);
            this.Controls.Add(this.txEmoDes);
            this.Controls.Add(this.txEmpQual);
            this.Controls.Add(this.txempName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "Removefrm";
            this.Text = "RemoveForm";
            this.Load += new System.EventHandler(this.Removefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rmGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txempName;
        private System.Windows.Forms.TextBox txEmpQual;
        private System.Windows.Forms.TextBox txEmoDes;
        private System.Windows.Forms.TextBox txEmpState;
        private System.Windows.Forms.DataGridView rmGrid;
        private System.Windows.Forms.Panel panel2;
    }
}