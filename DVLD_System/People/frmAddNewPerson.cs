using DVLD_System.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System.People
{
    public partial class frmAddNewPerson : Form
    {
        public event EventHandler DataUpdated;

        public event EventHandler<string> LastUpdatedNationalNoSaved;

        private string _LastSavedNationalNo = "";

        public string LastSavedNationalNo
        {
            get { return _LastSavedNationalNo; }
        }
        public frmAddNewPerson()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
        }

        private void frmAddNewPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);


            if(addPersonControl1.IsThereAnyChange)
            {
                _LastSavedNationalNo = addPersonControl1.MostRecentNationalNo;
                LastUpdatedNationalNoSaved?.Invoke(this, _LastSavedNationalNo);
            }
        }

        private void addPersonControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
