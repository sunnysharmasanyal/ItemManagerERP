namespace ItemManager
{
    partial class ItemManagerUI
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
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtItmLoc = new System.Windows.Forms.TextBox();
            this.txtItmWeight = new System.Windows.Forms.TextBox();
            this.txtItmLno = new System.Windows.Forms.TextBox();
            this.txtItmCount = new System.Windows.Forms.TextBox();
            this.txtItmType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItmColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Glbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightGray;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(692, 441);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 36);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 191);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // txtItmLoc
            // 
            this.txtItmLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItmLoc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItmLoc.Location = new System.Drawing.Point(594, 394);
            this.txtItmLoc.Name = "txtItmLoc";
            this.txtItmLoc.Size = new System.Drawing.Size(244, 31);
            this.txtItmLoc.TabIndex = 25;
            this.txtItmLoc.TextChanged += new System.EventHandler(this.txtItmLoc_TextChanged);
            // 
            // txtItmWeight
            // 
            this.txtItmWeight.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItmWeight.Location = new System.Drawing.Point(149, 388);
            this.txtItmWeight.Name = "txtItmWeight";
            this.txtItmWeight.Size = new System.Drawing.Size(244, 31);
            this.txtItmWeight.TabIndex = 24;
            // 
            // txtItmLno
            // 
            this.txtItmLno.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItmLno.Location = new System.Drawing.Point(594, 79);
            this.txtItmLno.Name = "txtItmLno";
            this.txtItmLno.Size = new System.Drawing.Size(244, 31);
            this.txtItmLno.TabIndex = 22;
            // 
            // txtItmCount
            // 
            this.txtItmCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItmCount.Location = new System.Drawing.Point(149, 127);
            this.txtItmCount.Name = "txtItmCount";
            this.txtItmCount.Size = new System.Drawing.Size(244, 31);
            this.txtItmCount.TabIndex = 21;
            // 
            // txtItmType
            // 
            this.txtItmType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItmType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItmType.Location = new System.Drawing.Point(149, 79);
            this.txtItmType.Name = "txtItmType";
            this.txtItmType.Size = new System.Drawing.Size(244, 31);
            this.txtItmType.TabIndex = 20;
            this.txtItmType.TextChanged += new System.EventHandler(this.txtItmType_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Item Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Item Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "ItemLot.no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Item Type";
            // 
            // cmbItmColor
            // 
            this.cmbItmColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbItmColor.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbItmColor.Location = new System.Drawing.Point(594, 127);
            this.cmbItmColor.Name = "cmbItmColor";
            this.cmbItmColor.Size = new System.Drawing.Size(244, 31);
            this.cmbItmColor.TabIndex = 23;
            this.cmbItmColor.TextChanged += new System.EventHandler(this.cmbItmColor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label7.Location = new System.Drawing.Point(331, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Add/Update/Delete";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(539, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 36);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Welcome";
            // 
            // Glbl
            // 
            this.Glbl.AutoSize = true;
            this.Glbl.Location = new System.Drawing.Point(761, 9);
            this.Glbl.Name = "Glbl";
            this.Glbl.Size = new System.Drawing.Size(35, 13);
            this.Glbl.TabIndex = 31;
            this.Glbl.Text = "Guest";
            // 
            // ItemManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 511);
            this.Controls.Add(this.Glbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbItmColor);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtItmLoc);
            this.Controls.Add(this.txtItmWeight);
            this.Controls.Add(this.txtItmLno);
            this.Controls.Add(this.txtItmCount);
            this.Controls.Add(this.txtItmType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemManagerUI";
            this.Load += new System.EventHandler(this.ItemManagerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtItmLoc;
        private System.Windows.Forms.TextBox txtItmWeight;
        private System.Windows.Forms.TextBox txtItmLno;
        private System.Windows.Forms.TextBox txtItmCount;
        private System.Windows.Forms.TextBox txtItmType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmbItmColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Glbl;
    }
}