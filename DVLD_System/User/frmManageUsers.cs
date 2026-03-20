using DC.User;
using DVLDBuisness.People;
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
    public partial class frmUserConfig : Form
    {
        private DataTable _dtAllUsers;

        private DataTable _dtUsers;

        private void _UploadDataTable()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");
        }

        private void _LoadDataGridView()
        {
            _UploadDataTable();
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.DataSource = _dtUsers;
            lblRecordNumber.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].ReadOnly = true;
                dgvUsers.Columns[4].Width = 120;

            }
        }
        public frmUserConfig()
        {
            InitializeComponent();
            _LoadDataGridView();
        }

        private void frmUserConfig_Load(object sender, EventArgs e)
        {
            cbFindUser.SelectedIndex = 0;
        }

        private void tbFindUser_TextChanged(object sender, EventArgs e)
        {
            if (tbFindUser.Text.Trim() == "")
            {
                dgvUsers.DataSource = _dtUsers;
                lblRecordNumber.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            else
            {

                // used the DataView to filter the DataTable based on the selected column and the filter text
                if (cbFindUser.Text == "PersonID")
                {
                    DataView dv = new DataView(_dtUsers);
                    dv.RowFilter = string.Format("Convert(PersonID, 'System.String') LIKE '%{0}%'", tbFindUser.Text.Trim().Replace("'", "''"));
                    dgvUsers.DataSource = dv.ToTable();
                    lblRecordNumber.Text = dgvUsers.Rows.Count.ToString();
                }
                else if (cbFindUser.Text == "UserID")
                {
                    DataView dv = new DataView(_dtUsers);
                    dv.RowFilter = string.Format("Convert(UserID, 'System.String') LIKE '%{0}%'", tbFindUser.Text.Trim().Replace("'", "''"));
                    dgvUsers.DataSource = dv.ToTable();
                    lblRecordNumber.Text = dgvUsers.Rows.Count.ToString();
                }
                else
                {
                    DataView dv = new DataView(_dtUsers);
                    dv.RowFilter = string.Format("{0} LIKE '%{1}%'", cbFindUser.Text, tbFindUser.Text.Trim().Replace("'", "''"));
                    dgvUsers.DataSource = dv.ToTable();
                    lblRecordNumber.Text = dgvUsers.Rows.Count.ToString();

                }

            }
        }

        private void tbFindUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbFindUser.Text == "PersonID" || cbFindUser.Text == "UserID") && !char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblRecordNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
            _LoadDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddNewUser = new frmAddNewUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value));
            frmAddNewUser.ShowDialog();
            _LoadDataGridView();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmShowUserInfo = new frmShowUserInfo(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value));
            frmShowUserInfo.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Res = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.No)
            {
                return;
            }

            else
            {

                if (clsUser.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value)))
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete the user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmUserChangePassword(Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value));
            frmChangePassword.ShowDialog();
        }
    }
}
