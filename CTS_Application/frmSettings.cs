using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_Application
{
    public partial class frmSettings : Form
    {
        //The DbConnect class cannot be declared globaly. If one want to delete several tables it will only work if its declared in each event.
        
        
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnDelRec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete all temperature recordings", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DbConnect con = new DbConnect();
                con.DeleteRecordsInTable("historian");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnDelAla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete all alarm recordings", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DbConnect con = new DbConnect();
                con.DeleteRecordsInTable("alarm_historian");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnDelSub_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete all subscribers", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DbConnect con = new DbConnect();
                con.DeleteRecordsInTable("users");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
