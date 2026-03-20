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
    public partial class frmUpdatePerson : Form
    {
        int _PersonID = -1;
        public frmUpdatePerson(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            addPersonControl1._PersonID = _PersonID;
        }

        private void addPersonControl1_Load(object sender, EventArgs e)
        {
        }

        private void frmUpdatePerson_Load(object sender, EventArgs e)
        {
        }
    }
}
