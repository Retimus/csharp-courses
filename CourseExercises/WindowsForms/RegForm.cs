using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsForms {
    public partial class RegForm : Form {
        public RegForm() {
            InitializeComponent();

            Random rnd = new Random();
            lblCodeGen.Text = rnd.Next(100, 999).ToString();
        }

        //
        // Labels

        //
        // Text fields
        private void txtName_LostFocus(object sender, EventArgs e) {
            ValidateName(false);
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            lblFullNameValue.Text = txtName.Text + " " + txtSurname.Text;
        }

        private void txtSurname_LostFocus(object sender, EventArgs e) {
            ValidateSurname(false);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e) {
            lblFullNameValue.Text = txtName.Text + " " + txtSurname.Text;
        }

        private void txtPassword_LostFocus(object sender, EventArgs e) {
            ValidatePassword(false);
        }

        private void txtRepPassword_LostFocus(object sender, EventArgs e) {
            ValidateRepPassword();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e) {
            mskdTxtSsn.Text = datePicker.Text.Replace(".", "").Remove(4,2) + mskdTxtSsn.Text.Remove(0,6);
        }

        private void mskdTxtSsn_LostFocus(object sender, EventArgs e) {
            ValidateSsn(false);
        }

        private void txtEmail_LostFocus(object sender, EventArgs e) {
            ValidateEmail(false);
        }

        //
        // Buttons
        private void btnSave_Click(object sender, EventArgs e) {
            ValidateName(true);
            ValidateSurname(true);
            ValidatePassword(true);
            ValidateRepPassword();
            ValidateSsn(true);
            ValidateEmail(true);
            ValidateCode();

            if (errorProviderName.GetError(txtName) == "" &&
                errorProviderSurname.GetError(txtSurname) == "" &&
                errorProviderPassword.GetError(txtPassword) == "" &&
                errorProviderRepPassword.GetError(txtRepPassword) == "" &&
                errorProviderSsn.GetError(mskdTxtSsn) == "" &&
                errorProviderEmail.GetError(txtEmail) == "" &&
                errorProviderCode.GetError(txtCode) == "") {
                string message = $"Successful registration for:\n\n  Full Name: {lblFullNameValue.Text}\n  Birthday: {datePicker.Text}\n  SSN: {mskdTxtSsn.Text}\n  E-mail: {txtEmail.Text}";
                MessageBox.Show(message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Dispose();
        }


        //
        // Validation
        private void ValidateName(bool onSave) {
            errorProviderName.Clear();

            if (onSave && txtName.Text.Length == 0) {
                errorProviderName.SetError(txtName, "Name is mandatory");
            }
            if (txtName.Text.Length > 0 && !Regex.IsMatch(txtName.Text, "^[a-zA-Z-]+$")) {
                errorProviderName.SetError(txtName, "Name can consist of alphabetical characters and dash");
            }
        }

        private void ValidateSurname(bool onSave) {
            errorProviderSurname.Clear();

            if (onSave && txtSurname.Text.Length == 0) {
                errorProviderSurname.SetError(txtSurname, "Surname is mandatory");
            }
            if (txtSurname.Text.Length > 0 && !Regex.IsMatch(txtSurname.Text, "^[a-zA-Z-]+$")) {
                errorProviderSurname.SetError(txtSurname, "This textbox accepts only alphabetical characters and dash");
            }
        }

        private void ValidatePassword(bool onSave) {
            errorProviderPassword.Clear();

            if (onSave && txtPassword.Text.Length == 0) {
                errorProviderPassword.SetError(txtPassword, "Password is mandatory");
            }
            if (txtPassword.Text.Length > 0 &&
                !Regex.IsMatch(txtPassword.Text, "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,}$")) {
                errorProviderPassword.SetError(txtPassword,
                    "Password must have:\n  at least 5 symbols;\n  at least one digit;\n  at least one capital letter;\n  at least one special symbol");
            }

            ValidateRepPassword();
        }

        private void ValidateRepPassword() {
            errorProviderRepPassword.Clear();

            if ((txtPassword.Text.Length > 0 && txtRepPassword.Text.Length == 0) ||
                (txtRepPassword.Text.Length > 0 && txtPassword.Text != txtRepPassword.Text)) {
                errorProviderRepPassword.SetError(txtRepPassword, "Passwords did not match");
            }
        }

        private void ValidateSsn(bool onSave) {
            errorProviderSsn.Clear();

            if (onSave && mskdTxtSsn.Text.Length == 0) {
                errorProviderSsn.SetError(mskdTxtSsn, "SSN is mandatory");
            }
            if (mskdTxtSsn.Text.Length != 12) {
                errorProviderSsn.SetError(mskdTxtSsn, "SSN is not completed");
            }
            if (datePicker.Text.Replace(".", "").Remove(4,2) != mskdTxtSsn.Text.Remove(6,6)) {
                errorProviderSsn.SetError(mskdTxtSsn, "SSN first part doesn't match birthday");
            }
        }

        private void ValidateEmail(bool onSave) {
            errorProviderEmail.Clear();

            if (onSave && txtEmail.Text.Length == 0) {
                errorProviderEmail.SetError(txtEmail, "Email is mandatory");
            }
            if (txtEmail.Text.Length > 0) {
                try {
                    var test = new MailAddress(txtEmail.Text);
                } catch (FormatException ex) {
                    errorProviderEmail.SetError(txtEmail, "Please enter valid email address");
                }
            }
        }

        private void ValidateCode() {
            errorProviderCode.Clear();

            if (txtCode.Text != lblCodeGen.Text) {
                errorProviderCode.SetError(txtCode, "Entered code is not correct");
            }
        }

    }
}
