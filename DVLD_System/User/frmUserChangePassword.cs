using DC.General_class_infos;
using DC.User;
using DVLDBuisness.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD_System.User
{
    public partial class frmUserChangePassword : Form
    {
        clsUser _User = null;
        public frmUserChangePassword(int UserID)
        {
            InitializeComponent();
            _User = clsUser.FindByUserID(UserID);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.DisableEditLink();
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            if (_User.IsActive)
            {
                lbllsActiveValue.ForeColor = Color.Green;
                lbllsActiveValue.Text = "Active";
            }
            else
            {
                lbllsActiveValue.ForeColor = Color.Red;
                lbllsActiveValue.Text = "Not Active";
            }

            lblUserIDValue.Text = _User.UserID.ToString();
            lblUsernameValue.Text = _User.UserName;
        }

        private void tbNewPassword_Leave(object sender, EventArgs e)
        {
            if (tbNewPassword.Text == "")
            {
                errProvNewPassword.SetError(tbNewPassword, "Please enter the new password.");
            }
            else
            {
                if (tbNewPassword.Text.Length < 6)
                {
                    errProvNewPassword.SetError(tbNewPassword, "Password must be at least 6 characters long.");
                }

                else if (tbNewPassword.Text == tbCurrentPassword.Text)
                {
                    errProvNewPassword.SetError(tbNewPassword, "New password cannot be the same as the current password.");
                }
                else
                    errProvNewPassword.Clear();
            }
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text == "")
            {
                errProvConfirmPassword.SetError(tbConfirmPassword, "Please confirm the password.");
            }
            else
            {
                if (tbConfirmPassword.Text != tbNewPassword.Text)
                {
                    errProvConfirmPassword.SetError(tbConfirmPassword, "Passwords do not match.");
                }
                else
                    errProvConfirmPassword.Clear();
            }
        }

        private void tbCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text == "")
            {
                errProvCurrentPassword.SetError(tbConfirmPassword, "Please confirm the password.");
            }
            else
            {
                if (tbCurrentPassword.Text != _User.Password)
                {
                    errProvCurrentPassword.SetError(tbCurrentPassword , "Wrong Password, Please try again.");
                }
                else
                    errProvCurrentPassword.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errorsList = new List<(ErrorProvider Provider, Control Control)>
             {
                    (errProvCurrentPassword, tbCurrentPassword),
                    (errProvNewPassword, tbNewPassword),
                    (errProvConfirmPassword, tbConfirmPassword),
             };

            if (clsValidations.HasAnyError(errorsList))
            {
                MessageBox.Show("There are missing informations or Passwords do not match");
            }


            else
            {
                _User.Password = tbNewPassword.Text;

                if(_User.Save())
                {
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while changing the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
