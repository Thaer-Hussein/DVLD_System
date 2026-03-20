using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace DVLDBuisness.GeneralFuncs
{
    public class clsGeneral
    {
        public static void CloseForm(Form frm) => frm.Close();

        public static void ShowForm(Form frm) => frm.Show();

        public static void ShowDialogForm(Form frm) => frm.ShowDialog();

        public static void ChangeToolStripMenuBackToCertainColor(ToolStripMenuItem item , Color clr) => item.BackColor = clr;

        public static void ChangeToolStripMenuForeToCertainColor(ToolStripMenuItem item, Color clr) => item.ForeColor = clr;

    }
}
