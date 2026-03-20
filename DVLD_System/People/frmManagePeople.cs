using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBuisness.People;
namespace DVLD_System.People
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _dtAllPeople;

        private DataTable _dtPeople;

        private void _UploadDataTable()
        {
            _dtAllPeople = clsPerson.GetAllPersons();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GendorCaption", "DateOfBirth", "CountryName",
                                                         "Phone", "Email");
        }

        private void _LoadDataGridView()
        {
            _UploadDataTable();
            dgvPeople.AutoGenerateColumns = true;
            dgvPeople.DataSource = _dtPeople;
           cmbFilterBy.SelectedIndex = 0;
            lblRecordsNumberValue.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;
            }
        }
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadDataGridView();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.DataUpdated += (s, ea) => { _LoadDataGridView(); };
            frm.ShowDialog();
            frm.DataUpdated -= (s, ea) => { _LoadDataGridView(); };
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "PersonID" && !char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbFilter.Text.Trim() == "")
            {
                dgvPeople.DataSource = _dtPeople;
                lblRecordsNumberValue.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            else
            {

                // used the DataView to filter the DataTable based on the selected column and the filter text
                if (cmbFilterBy.Text == "PersonID")
                {
                    DataView dv = new DataView(_dtPeople);
                    dv.RowFilter = string.Format("Convert(PersonID, 'System.String') LIKE '%{0}%'", tbFilter.Text.Trim().Replace("'", "''"));
                    dgvPeople.DataSource = dv.ToTable();
                    lblRecordsNumberValue.Text = dgvPeople.Rows.Count.ToString();
                }
                else
                {
                    DataView dv = new DataView(_dtPeople);
                    dv.RowFilter = string.Format("{0} LIKE '%{1}%'", cmbFilterBy.Text, tbFilter.Text.Trim().Replace("'", "''"));
                    dgvPeople.DataSource = dv.ToTable();
                    lblRecordsNumberValue.Text = dgvPeople.Rows.Count.ToString();

                }

            }
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmUpdatePerson frm = new frmUpdatePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value));
            frm.ShowDialog();
            _LoadDataGridView();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Res = MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                clsPerson.DeletePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value));
                _LoadDataGridView();
            }
        }

        private void ShowInfoToolStripMenuItem__Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value));
            frm.ShowDialog();
            _LoadDataGridView();

        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmShowPersonInfo(Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value));
            frm.ShowDialog();
        }
    }
}
