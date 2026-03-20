using DC.User;
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
    public partial class frmShowUserInfo : Form
    {
        
        clsUser _User = new clsUser();
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _User = clsUser.FindByUserID(UserID);

        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
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
    }
}
