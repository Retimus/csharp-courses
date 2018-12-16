namespace LINQ
{
    partial class frmEmployeeGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.btnSelect_1 = new System.Windows.Forms.Button();
            this.btnSelect_2 = new System.Windows.Forms.Button();
            this.btmSelect_3 = new System.Windows.Forms.Button();
            this.btnSelect_4 = new System.Windows.Forms.Button();
            this.btnSelect_5 = new System.Windows.Forms.Button();
            this.btnSelect_6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvEmployees.Location = new System.Drawing.Point(340, 13);
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvEmployees.Size = new System.Drawing.Size(786, 384);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderByName.Location = new System.Drawing.Point(13, 13);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(139, 30);
            this.btnOrderByName.TabIndex = 1;
            this.btnOrderByName.Text = "Order By Name";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            this.btnOrderByName.Click += new System.EventHandler(this.btnOrderByName_Click);
            // 
            // btnSelect_1
            // 
            this.btnSelect_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_1.Location = new System.Drawing.Point(13, 67);
            this.btnSelect_1.Name = "btnSelect_1";
            this.btnSelect_1.Size = new System.Drawing.Size(139, 30);
            this.btnSelect_1.TabIndex = 2;
            this.btnSelect_1.Text = "1";
            this.btnSelect_1.UseVisualStyleBackColor = true;
            this.btnSelect_1.Click += new System.EventHandler(this.btnSelect_1_Click);
            // 
            // btnSelect_2
            // 
            this.btnSelect_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_2.Location = new System.Drawing.Point(180, 67);
            this.btnSelect_2.Name = "btnSelect_2";
            this.btnSelect_2.Size = new System.Drawing.Size(139, 30);
            this.btnSelect_2.TabIndex = 3;
            this.btnSelect_2.Text = "2";
            this.btnSelect_2.UseVisualStyleBackColor = true;
            this.btnSelect_2.Click += new System.EventHandler(this.btnSelect_2_Click);
            // 
            // btmSelect_3
            // 
            this.btmSelect_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSelect_3.Location = new System.Drawing.Point(13, 103);
            this.btmSelect_3.Name = "btmSelect_3";
            this.btmSelect_3.Size = new System.Drawing.Size(139, 30);
            this.btmSelect_3.TabIndex = 4;
            this.btmSelect_3.Text = "3";
            this.btmSelect_3.UseVisualStyleBackColor = true;
            this.btmSelect_3.Click += new System.EventHandler(this.btmSelect_3_Click);
            // 
            // btnSelect_4
            // 
            this.btnSelect_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_4.Location = new System.Drawing.Point(180, 103);
            this.btnSelect_4.Name = "btnSelect_4";
            this.btnSelect_4.Size = new System.Drawing.Size(139, 30);
            this.btnSelect_4.TabIndex = 5;
            this.btnSelect_4.Text = "4";
            this.btnSelect_4.UseVisualStyleBackColor = true;
            this.btnSelect_4.Click += new System.EventHandler(this.btnSelect_4_Click);
            // 
            // btnSelect_5
            // 
            this.btnSelect_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_5.Location = new System.Drawing.Point(13, 139);
            this.btnSelect_5.Name = "btnSelect_5";
            this.btnSelect_5.Size = new System.Drawing.Size(139, 30);
            this.btnSelect_5.TabIndex = 6;
            this.btnSelect_5.Text = "5";
            this.btnSelect_5.UseVisualStyleBackColor = true;
            this.btnSelect_5.Click += new System.EventHandler(this.btnSelect_5_Click);
            // 
            // btnSelect_6
            // 
            this.btnSelect_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_6.Location = new System.Drawing.Point(180, 139);
            this.btnSelect_6.Name = "btnSelect_6";
            this.btnSelect_6.Size = new System.Drawing.Size(139, 30);
            this.btnSelect_6.TabIndex = 7;
            this.btnSelect_6.Text = "6";
            this.btnSelect_6.UseVisualStyleBackColor = true;
            this.btnSelect_6.Click += new System.EventHandler(this.btnSelect_6_Click);
            // 
            // frmEmployeeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 409);
            this.Controls.Add(this.btnSelect_6);
            this.Controls.Add(this.btnSelect_5);
            this.Controls.Add(this.btnSelect_4);
            this.Controls.Add(this.btmSelect_3);
            this.Controls.Add(this.btnSelect_2);
            this.Controls.Add(this.btnSelect_1);
            this.Controls.Add(this.btnOrderByName);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmEmployeeGrid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.Button btnSelect_1;
        private System.Windows.Forms.Button btnSelect_2;
        private System.Windows.Forms.Button btmSelect_3;
        private System.Windows.Forms.Button btnSelect_4;
        private System.Windows.Forms.Button btnSelect_5;
        private System.Windows.Forms.Button btnSelect_6;
    }
}

