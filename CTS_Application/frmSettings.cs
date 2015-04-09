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
        DbConnect con = new DbConnect();
        
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnDelRec_Click(object sender, EventArgs e)
        {
            con.DeleteRecordsInTable("historian");
        }

        private void btnDelAla_Click(object sender, EventArgs e)
        {
            con.DeleteRecordsInTable("alarm_historian");
        }

        private void btnDelSub_Click(object sender, EventArgs e)
        {
            con.DeleteRecordsInTable("users");
        }

    
    }
}
