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
    public partial class frmAddNewUser : Form
    {
        private bool _allowTabChange = false;

        int _PersonID = -1;
        string _NationalNo = string.Empty;
        int _UserID = -1;
        public frmAddNewUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _CurrentMode = enMode.Update;
        }

        public frmAddNewUser()
        {
            InitializeComponent();
        }



        clsUser _User = new clsUser();

        enum enMode { AddNew = 0, Update = 1 };
        enMode _CurrentMode = enMode.AddNew;
        private void AllowNextButton()
        {
            btnPersonInfoNext.Enabled = true;
            _PersonID = ctrlPersonCardWithFilter1.PersonID;
            _NationalNo = ctrlPersonCardWithFilter1.NationalNo;
        }

        private void PreventNextButton()
        {
            btnPersonInfoNext.Enabled = false;
            _PersonID = -1;
            _NationalNo = string.Empty;
        }
        private void ctrlPersonCardWithFilter2_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.AllowNextInUserAdding += (s, args) => AllowNextButton();
            ctrlPersonCardWithFilter1.PreventNextInUserAdding += (s, args) => PreventNextButton();


            if (_CurrentMode == enMode.Update)
            {
                _allowTabChange = true;
                tcAddNewUser.SelectedIndex = 1;
                _allowTabChange = false;
                btnSave.Enabled = true;

                _User = clsUser.FindByUserID(_UserID);

                txtConfirmPassword.Enabled = false;
                txtPassword.Enabled = false;
                txtUserName.Text = _User.UserName;
                chkIsActive.Checked = _User.IsActive;
            }
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (clsUser.FindByPersonID(_PersonID) != null)
            {
                MessageBox.Show("This person already has a user account, you can edit it by searching for the user account using the username or national number");
            }

            else
            {
                _allowTabChange = true;
                tcAddNewUser.SelectedIndex += 1; // move to next tab
                _allowTabChange = false;

                if (_PersonID != -1 || _NationalNo != "")
                {
                    btnSave.Enabled = true;
                }
            }

            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                errProvUserName.SetError(txtUserName, "Please enter a username.");
            }

            else
            {
                errProvUserName.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errProvPassword.SetError(txtPassword, "Please enter a password.");
            }
            else
            {
                if (txtPassword.Text.Length < 6)
                {
                    errProvPassword.SetError(txtPassword, "Password must be at least 6 characters long.");
                }
                else
                    errProvPassword.Clear();
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                errProvConfirmPassword.SetError(txtConfirmPassword, "Please confirm the password.");
            }
            else
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    errProvConfirmPassword.SetError(txtConfirmPassword, "Passwords do not match.");
                }
                else
                    errProvConfirmPassword.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errorsList = new List<(ErrorProvider Provider, Control Control)>
               {
                      (errProvConfirmPassword, txtConfirmPassword),
                      (errProvPassword, txtPassword),
                      (errProvUserName, txtUserName)
               };

            if (clsValidations.HasAnyError(errorsList))
            {
                MessageBox.Show("There are missing informations");
            }


            else
            {
                if (_CurrentMode == enMode.AddNew)
                {
                    _User.UserName = txtUserName.Text;
                    _User.Password = txtPassword.Text;
                    _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
                    _User.IsActive = chkIsActive.Checked;


                    if (_User.Save())
                    {
                        MessageBox.Show("Person Was Added Succefly");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Person was not added due to a problem");
                    }
                }

                else
                {
                    _User.UserName = txtUserName.Text;
                    _User.IsActive = chkIsActive.Checked;   
                    if (_User.Save())
                    {
                        MessageBox.Show("Person Was Edited Succefly");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Person was not edited due to a problem");
                    }
                }
            } 
                
        }

        private void tcAddNewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tcAddNewUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!_allowTabChange)
            {
                e.Cancel = true;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
