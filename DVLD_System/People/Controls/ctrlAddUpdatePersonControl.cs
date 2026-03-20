using DC.Countries;
using DVLDBuisness.Format;
using DVLDBuisness.People;
using DVLDBuisness.Validations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DC.GeneralFuncs;
using System.Runtime.InteropServices;
namespace DVLD_System.Controls
{
    public partial class AddUpdatePersonControl : UserControl
    {
        public int _PersonID = -1;
        private bool _IsThereAnyChange = false;
        private string _MostRecentNationalNo = "";
        public bool IsThereAnyChange
        {
            get { return _IsThereAnyChange; }
        }
        public string MostRecentNationalNo
            {
            get { return _MostRecentNationalNo; }
        }
        clsPerson _Person = new clsPerson();
        private enum enMode  {AddNew = 1 , Update = 2};
        private enMode _CurrentMode = enMode.AddNew;
        public AddUpdatePersonControl()
        {
            InitializeComponent();
        }

        private void AddPersonControl_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            cbCountry.DataSource = clsCountries.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

            if (_PersonID != -1)
            {
                enMode CurrentMode = enMode.Update;
                _Person = clsPerson.FindByPersonID(_PersonID);

                tbFirst.Text = _Person.FirstName;
                tbSecond.Text = _Person.SecondName;
                tbThird.Text = _Person.ThirdName;
                tbFourth.Text = _Person.LastName;
                dtpDateOfBirth.Value = _Person.DateOfBirth ?? DateTime.Now.AddYears(-18);
                tbAddress.Text = _Person.Address;
                tbPhone.Text = _Person.Phone;
                tbEmail.Text = _Person.Email;
                cbCountry.SelectedValue = _Person.NationalityID;
                tbNationalNo.Text = _Person.NationalNo;
                if (!string.IsNullOrWhiteSpace(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    pbAddUser.Load(_Person.ImagePath);
                }
                else
                {
                    pbAddUser.Image = Properties.Resources.user_big;
                }

                if(_Person.Gender)
                    rbFemale.Checked = true;
                else
                    rbMale.Checked = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                if (!clsFormat.CheckTheEmailFormat(tbEmail.Text))
                {
                    errEmail.SetError(tbEmail, "Invalid format");
                }

                else
                    errEmail.Clear();

            }

            else
                errEmail.SetError(tbEmail, "This field is required");
        }

        private void tbFirst_TextChanged(object sender, EventArgs e)
        {
            errFirstName.Clear();

        }

        private void tbFirst_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirst.Text))
            {
                errFirstName.SetError(tbFirst, "This field is required");
            }

        }

        private void tbSecond_TextChanged(object sender, EventArgs e)
        {
            errSecondName.Clear();
        }

        private void tbSecond_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSecond.Text))
            {
                errSecondName.SetError(tbSecond, "This field is required");
            }
        }

        private void tbThird_TextChanged(object sender, EventArgs e)
        {
            errThirdName.Clear();
        }

        private void tbThird_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbThird.Text))
            {
                errThirdName.SetError(tbThird, "This field is required");
            }

        }

        private void tbFourth_TextChanged(object sender, EventArgs e)
        {
            errFourthName.Clear();
        }

        private void tbFourth_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFourth.Text))
            {
                errFourthName.SetError(tbFourth, "This field is required");
            }

        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {
            errNationalNo.Clear();
        }

        private void tbNationalNo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNationalNo.Text))
            {
                if (clsPerson.CheckIfPersonExistsByTheNationalNo(tbNationalNo.Text.Trim()))
                {
                    errNationalNo.SetError(tbNationalNo, "This National No already exists in the system");
                }

            }

            else
                errNationalNo.SetError(tbNationalNo, "This field is required");
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            errPhone.Clear();
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                if (!clsFormat.CheckThePhoneFormat(tbPhone.Text))
                {
                    errPhone.SetError(tbPhone, "Invalid format");
                }
            }

            else
                errPhone.SetError(tbPhone, "This field is required");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errorsList = new List<(ErrorProvider Provider, Control Control)>
             {
                    (errEmail, tbEmail),
                    (errFirstName, tbFirst),
                    (errSecondName, tbSecond),
                    (errThirdName, tbThird),
                    (errFourthName, tbFourth),
                    (errNationalNo, tbNationalNo),
                    (errPhone, tbPhone)
             };

            if (clsValidations.HasAnyError(errorsList))
            {
                MessageBox.Show("There are missing informations");
            }

            else
            {

                if(!_HandlePersonImage())
                {
                    return;
                }


                if (_CurrentMode == enMode.AddNew)
                {

                    _Person.NationalNo = tbNationalNo.Text.Trim();
                    _Person.FirstName = tbFirst.Text.Trim();
                    _Person.SecondName = tbSecond.Text.Trim();
                    _Person.ThirdName = tbThird.Text.Trim();
                    _Person.LastName = tbFourth.Text.Trim();
                    _Person.DateOfBirth = dtpDateOfBirth.Value;
                    _Person.Gender = rbFemale.Checked;
                    _Person.Address = tbAddress.Text.Trim();
                    _Person.Phone = tbPhone.Text.Trim();
                    _Person.Email = tbEmail.Text.Trim();
                    _Person.NationalityID = (int)cbCountry.SelectedValue;
                    _Person.ImagePath = pbAddUser.ImageLocation ?? "";

                    if(_Person.Save())
                    {
                        _MostRecentNationalNo = _Person.NationalNo;
                        _IsThereAnyChange = true;
                        MessageBox.Show("Person added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form parentForm = this.FindForm();   
                        parentForm?.Close();
                    }

                    else 
                        {
                        MessageBox.Show("Error adding person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    _Person = clsPerson.FindByPersonID(_PersonID);

                    if (_Person.Save())
                    {
                        _MostRecentNationalNo = _Person.NationalNo;
                        _IsThereAnyChange = true;
                        MessageBox.Show("Person added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error adding person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



            }


        }

        private void lnklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbAddUser.Load(selectedFilePath);
                lnkRemoveImage.Visible = true;
                // ...
            }
        }

        private void lnkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbAddUser.Image = Properties.Resources.user_big;
        }


        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbAddUser.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbAddUser.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbAddUser.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbAddUser.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
