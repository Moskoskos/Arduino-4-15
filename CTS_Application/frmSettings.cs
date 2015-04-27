using System;
using System.Windows.Forms;
using System.IO.Ports;

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

            //show list of valid com ports
            foreach (string s in SerialPort.GetPortNames())
            {
                cboCOMPort.Items.Add(s);
            }

            cboCOMPort.Text = dbRead.GetComPort(1); //Fill cbo with current COM-port on start.
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void FillTextBoxes()
        {
            txtSpL.Text = dbRead.GetLowSP(1);
            txtSpH.Text = dbRead.GetHighSp(1);

        }

        private void btnDelRec_Click(object sender, EventArgs e)
        {
            //Source:
            //http://stackoverflow.com/questions/3036829/how-to-create-a-message-box-with-yes-no-choices-and-a-dialogresult-in-c
            //
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int setPointLow = Convert.ToInt32(txtSpL.Text);
                int setPointHigh = Convert.ToInt32(txtSpH.Text);
                dbEdit.ChangeSetPoint(1, setPointLow, setPointHigh);
                lblChange.Text = "Setpoint(s) updated!";
            }
            catch (Exception ex)
            {
                lblChange.Text = "Could not update!";
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCOMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dbEdit.EditComPort(1, cboCOMPort.Text);
            //    MessageBox.Show("COM port selected.");
            //}
            //catch (Exception)
            //{
            //    lblChange.Text = "Could not set COM port.";
            //    throw;
            //}
        }

        private void cboCOMPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    MessageBox.Show(cboCOMPort.SelectedText);
            //    dbEdit.EditComPort(1, cboCOMPort.SelectedText);
            //    MessageBox.Show("COM port selected.");
            //}
            //catch (Exception)
            //{
            //    lblChange.Text = "Could not set COM port.";
            //    throw;
            //}
        }

        private void cboCOMPort_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                dbEdit.EditComPort(1, cboCOMPort.Text);
                MessageBox.Show("COM port selected.");

            }
            catch (Exception)
            {
                lblChange.Text = "Could not set COM port.";
                throw;
            }
        }
    }
}
