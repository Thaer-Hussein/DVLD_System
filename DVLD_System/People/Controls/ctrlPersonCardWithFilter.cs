using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_System.People;
namespace DVLD_System.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        private string _LastSavedNationalNo = "";

        public  event EventHandler AllowNextInUserAdding;

        public event EventHandler PreventNextInUserAdding;

        public int PersonID = -1;
        public string NationalNo = "";
        private void SaveLastSavedNationalNo(string nationalNo)
        {
            _LastSavedNationalNo = nationalNo;
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" && !char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFilterValue.Text == "")
            {
                MessageBox.Show("Please enter a value to filter by.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                if (cbFilterBy.Text == "Person ID")
                {
                    if (ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text.Trim())))
                    {
                        PersonID = int.Parse(txtFilterValue.Text.Trim());
                        AllowNextInUserAdding?.Invoke(this, EventArgs.Empty);
                    }

                    else
                    {
                        PersonID = -1;
                        PreventNextInUserAdding?.Invoke(this, EventArgs.Empty);
                    }


                }
                else
                {
                    if (ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text.Trim()))
                    {
                        NationalNo = txtFilterValue.Text.Trim();
                        PersonID = ctrlPersonCard1.PersonID;
                        AllowNextInUserAdding?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        NationalNo = "";
                        PreventNextInUserAdding?.Invoke(this, EventArgs.Empty);
                    }
                }


                if (OnPersonSelected != null )
                    // Raise the event with a parameter
                    OnPersonSelected(ctrlPersonCard1.PersonID);
            }
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var frmAddNewPerson = new frmAddNewPerson();

            frmAddNewPerson.LastUpdatedNationalNoSaved += (s, nationalNo) =>
            {
                SaveLastSavedNationalNo(nationalNo);
                txtFilterValue.Text = nationalNo;
                cbFilterBy.SelectedIndex = 0; // Set filter to National No.
                btnFind.PerformClick(); // Trigger the find action
            };

            frmAddNewPerson.ShowDialog();


        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        public void FilterDisable()
        {
            cbFilterBy.Enabled = false;
            txtFilterValue.Enabled = false;
            btnFind.Enabled = false;
            btnAddNewPerson.Enabled = false;
        }

        public void FilterEnable()
        {
            cbFilterBy.Enabled = true;
            txtFilterValue.Enabled = true;
            btnFind.Enabled = true;
            btnAddNewPerson.Enabled = true;
        }

        public void LoadPersonInfo(int personID)
        {
            if(ctrlPersonCard1.LoadPersonInfo(personID))
            {
                MessageBox.Show("Person information loaded successfully for ID = " + personID, "Person Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonID = personID;
            }
            else
            {
                MessageBox.Show("Could not find person with ID = " + personID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void gbFilters_Enter(object sender, EventArgs e)
        {

        }
    }
}
