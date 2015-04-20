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
        DbEdit dbEdit = new DbEdit();
        DbRead dbRead = new DbRead();
        DbWrite dbWrite = new DbWrite();
        
        public frmSettings()
        {        
            InitializeComponent();
            FillTextBoxes();
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void FillTextBoxes()
        {
            txtSpL.Text = dbRead.GetLowSP(1);
            txtSpH.Text = dbRead.GetHighSp(1);
            txtCom.Text = dbRead.GetComPort(1);
            if (txtSpH.Text == "" && txtSpL.Text == "" && txtCom.Text == "")
            {
                MessageBox.Show("If this is the first time the application has been started there are no values present. Close this window and open it again. \r\r\n  If this is the second time you are opening this window please make sure that the Mysql server is running. Processname = mysqld");
            }

        }

        private void btnDelRec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete all temperature recordings", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dbEdit.DeleteRecordsInTable("historian");
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
                dbEdit.DeleteRecordsInTable("alarm_historian");
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
                dbEdit.DeleteRecordsInTable("users");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnSubCom_Click(object sender, EventArgs e)
        {
            dbEdit.EditComPort(1, txtCom.Text);
            ArduinoCom arCom = new ArduinoCom();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int setPointLow = Convert.ToInt32(txtSpL.Text);
                int setPointHigh = Convert.ToInt32(txtSpH.Text);
                dbEdit.ChangeSetPoint(1, setPointLow, setPointHigh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
