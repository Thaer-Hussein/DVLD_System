using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DC.User;
using DVLD_System.Main;
using DVLDBuisness.GeneralFuncs;
using DC.General_class_infos;
namespace DVLD_System
{
    public partial class frmLogin : Form
    {
        private clsUser _User = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
             
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = clsUser.FindByUsernameAndPassword(tbUsername.Text, tbPassword.Text);

            if (_User != null)
            {
                if (_User.IsActive)
                {

                    Form frm = new frmMain(_User);
                    clsGeneral_class_infos.LoadUserClassInfo(_User.UserID);
                    this.Hide();
                    clsGeneral.ShowDialogForm(frm);
                    this.Show();
                }

                else
                {
                    MessageBox.Show("This user is inactive. Please contact the administrator.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            clsGeneral.CloseForm(this);
        }
    }
}
