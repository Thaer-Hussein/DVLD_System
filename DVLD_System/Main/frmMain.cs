using DVLDBuisness.GeneralFuncs;
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
using DC.User;
using DVLD_System.User;
using DC.General_class_infos;
using DVLD_System.ApplicationTypes;
using DVLD_System.Tests.Test_Types;
using DVLD_System.License.Local_Driving_License;
using DVLD_System.Applications.License.International_Driving_License;
using DVLD_System.Applications.License.Release_Detained_License;
using DVLD_System.Applications.License.Renew_Local_License;
using DVLD_System.Applications.License.Replace_Lost_Or_Damaged_License;
using DVLD_System.Applications.ApplicationTypes;
using DVLD_System.Licenses.Detain_License;
using DVLD_System.Drivers;
namespace DVLD_System.Main
{
    public partial class frmMain : Form
    {
        private clsUser _User = null;
        public frmMain(clsUser User)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _User = User;
        }

        private void ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            clsGeneral.ChangeToolStripMenuBackToCertainColor(temp, Color.White);
            clsGeneral.ChangeToolStripMenuForeToCertainColor(temp, Color.MidnightBlue);
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            clsGeneral.ChangeToolStripMenuBackToCertainColor(temp, Color.MidnightBlue);
            clsGeneral.ChangeToolStripMenuForeToCertainColor(temp, Color.White);
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople managePeople = new frmManagePeople();

            managePeople.ShowDialog();
        }

        private void pbKingdomLogo_Click(object sender, EventArgs e)
        {

        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _User.UserName;
            lblActiveKey.Text = Guid.NewGuid().ToString().Substring(0 , 8);

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new User.frmUserConfig();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmShowMyInfo = new frmShowUserInfo(clsGeneral_class_infos.User.UserID);
            frmShowMyInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmChangeMyPassword = new frmUserChangePassword(clsGeneral_class_infos.User.UserID);
            frmChangeMyPassword.ShowDialog();

            if (clsUser.FindByUserID(clsGeneral_class_infos.User.UserID).Password != clsGeneral_class_infos.User.Password)
            {
                MessageBox.Show("Your password has been changed. Please sign in again with your new password.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTestTypes = new frmListTestTypes();
            frmTestTypes.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmApplicationTypes = new frmManageApplicationTypes();
            frmApplicationTypes.ShowDialog();
        }

        private void renewDriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRenew = new frmRenewLocalDrivingLicenseApplication();
            frmRenew.ShowDialog();
        }

        private void replacementForLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thaerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLocalDrivingLicenseApplication = new frmAddUpdateLocalDrivingLicesnseApplication();
            frmLocalDrivingLicenseApplication.ShowDialog();
        }

        private void internationalDrivingLicesnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmInternationalLicenseApplication = new frmNewInternationalLicenseApplication();
            frmInternationalLicenseApplication.ShowDialog();
        }

        private void replacementForLostOrDamagedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReplace = new frmReplaceLostOrDamagedLicenseApplication();
            frmReplace.ShowDialog();
        }

        private void ReleaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReleaseDetainedLicense = new frmReleaseDetainedLicenseApplication();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void retakeTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmRetakeTest = new frmLocalDrivingLicenseApplicationsList();
            frmRetakeTest.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLocalDrivingLicenseList = new frmLocalDrivingLicenseApplicationsList();
            frmLocalDrivingLicenseList.ShowDialog();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmInternationalDrivingLicense = new frmListInternationalLicesnseApplications();
            frmInternationalDrivingLicense.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDetainedLicenseList = new frmListDetainedLicenses();
            frmDetainedLicenseList.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDetainLicense = new frmDetainLicenseApplication();
            frmDetainLicense.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRealseLicense = new frmReleaseDetainedLicenseApplication();
            frmRealseLicense.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDrivers = new frmListDrivers();
            frmDrivers.ShowDialog();
        }
    }
}
