namespace WindowsForms {
    partial class RegForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepPassword = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepPassword = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.mskdTxtSsn = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 40);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(86, 80);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 24);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(76, 120);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(102, 24);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(81, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblRepPassword
            // 
            this.lblRepPassword.AutoSize = true;
            this.lblRepPassword.Location = new System.Drawing.Point(16, 200);
            this.lblRepPassword.Name = "lblRepPassword";
            this.lblRepPassword.Size = new System.Drawing.Size(162, 24);
            this.lblRepPassword.TabIndex = 4;
            this.lblRepPassword.Text = "Repeat Password:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(96, 240);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(82, 24);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Location = new System.Drawing.Point(125, 280);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(53, 24);
            this.lblSsn.TabIndex = 6;
            this.lblSsn.Text = "SSN:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(110, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(117, 360);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(61, 24);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Code:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(274, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 29);
            this.txtName.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(184, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(280, 29);
            this.txtSurname.TabIndex = 12;
            this.txtSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 29);
            this.txtPassword.TabIndex = 13;
            // 
            // txtRepPassword
            // 
            this.txtRepPassword.Location = new System.Drawing.Point(184, 200);
            this.txtRepPassword.Name = "txtRepPassword";
            this.txtRepPassword.Size = new System.Drawing.Size(280, 29);
            this.txtRepPassword.TabIndex = 14;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(184, 240);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(114, 29);
            this.datePicker.TabIndex = 16;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 29);
            this.txtEmail.TabIndex = 18;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(184, 360);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(70, 29);
            this.txtCode.TabIndex = 19;
            // 
            // mskdTxtSsn
            // 
            this.mskdTxtSsn.Location = new System.Drawing.Point(184, 280);
            this.mskdTxtSsn.Mask = "000000-00000";
            this.mskdTxtSsn.Name = "mskdTxtSsn";
            this.mskdTxtSsn.Size = new System.Drawing.Size(130, 29);
            this.mskdTxtSsn.TabIndex = 20;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 498);
            this.Controls.Add(this.mskdTxtSsn);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtRepPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblRepPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Location = new System.Drawing.Point(36, 34);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegForm";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepPassword;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepPassword;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.MaskedTextBox mskdTxtSsn;
    }
}

