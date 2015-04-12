using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;
using System.Threading.Tasks;
using System.Threading;


namespace CTS_Application
{
    public partial class frmMain : Form
    {
        double temp_Arduino = 0.0;
        double days = 0.0;
        DbConnect dbConGlob = new DbConnect();
        ArduinoCom arcom = new ArduinoCom();
        BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); //Declare batterymonitoring class
        public frmMain()
        {
            InitializeComponent();

            //show percentage left in label.
            lblPercentage.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "% available"; 

            //Checks whether the battery status can be read or not. If -1 then no. 
            if (batteryMonitoring.TimeLeft > 0)  {lblTimeLeft.Text = batteryMonitoring.TimeLeft.ToString();}
            else{lblTimeLeft.Text = "System could not calculate remaining time. Driver missing!";}
            lblState.Text = batteryMonitoring.Status;
            tmrStatus.Start();
           
           // dateTimePicker1.Value = DateTime.Today;
           // dateTimePicker2.Value = DateTime.MaxValue.AddDays(1);
            //chrtTemp.ChartAreas["Series1"].AxisX.Maximum = dateTimePicker1.Value;
           // chrtTemp.ChartAreas["Series1"].AxisX.Minimum = 0;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetToGrah.historian' table. You can move, or remove it, as needed.
            this.historianTableAdapter.Fill(this.dataSetToGrah.historian);
            // TODO: This line of code loads data into the 'dataSetAlarmEvents.alarm_historian' table. You can move, or remove it, as needed.
            this.alarm_historianTableAdapter.Fill(this.dataSetAlarmEvents.alarm_historian);
           
            //Source:
            //http://stackoverflow.com/questions/12033448/how-to-connect-two-different-windows-forms-keeping-both-open
            //Where to place the window at startup
            this.Location = new Point(0, 0);
           // chrtTemp.ChartAreas["Series1"].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm";
            
        }

        //Opens the subscriber window
        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            Subscribers sub = new Subscribers();
            sub.Show();
        }
        //Ever x-interval the program retrieves the system information related to battery status
        //default: Every 30 second.
  


       private void tmrSimTemp_Tick(object sender, EventArgs e)
       {
           temp_Arduino = arcom.Temperature(days);
           txtCV.Text = Convert.ToString(temp_Arduino) + "°C";
           days = days + 1;
       }

       private void btnSubmit_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           int setPointLow = Convert.ToInt32(txtSpL.Text);
           int setPointHigh = Convert.ToInt32(txtSpH.Text);
           int hysteresis = Convert.ToInt32(txtHysteresis.Text);
           con.ChangeSetPoint(1, setPointLow, setPointHigh, hysteresis);
       }

       private void tmrRecToDb_Tick(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           try
           {
               //write temp to db
               con.WriteTempemperatureToHistorian(temp_Arduino);
               // Update chart with temp
               this.historianTableAdapter.Fill(this.dataSetToGrah.historian);
               chrtTemp.DataBind();
               chrtTemp.Refresh();
           }
           catch (Exception ex)
           {
               tmrRecToDb.Stop();
               MessageBox.Show(ex.Message);
           }
       }
       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
       {

       }

       private void menuSettings_Click(object sender, EventArgs e)
       {
           frmSettings SettingsWindow = new frmSettings();
           SettingsWindow.Show();
       }

        private void DisplayXAxis()
       {

       }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            //Simulate temp
            tmrSimTemp.Start();
            if (days == (3 * 365)) { tmrSimTemp.Stop(); }
            tmrRecToDb.Start();
        }

        private void btnStopSim_Click(object sender, EventArgs e)
        {
            tmrSimTemp.Stop();
            tmrRecToDb.Stop();
        }

        private void tmrStatus_Tick(object sender, EventArgs e)
        {
            BatteryMonitoring batteryMonitoring = new BatteryMonitoring();
            lblPercentage.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "% available";
            if (batteryMonitoring.TimeLeft >= 1)
            {
                lblTimeLeft.Text = batteryMonitoring.TimeLeft.ToString();
            }
            else
            {
                lblTimeLeft.Text = "System could not calculate remaining time. Driver missing";
            }
            lblState.Text = batteryMonitoring.Status;
            //Displays the programs current memory Usage. Excludes MySQL
            long memory = GC.GetTotalMemory(true);
            if (memory > 1048576) { lblMemory.Text = "Memory usage: " + (memory / 1024 / 1024).ToString() + "MB"; }
            else { lblMemory.Text = "Memory usage: " + (memory / 1024).ToString() + "KB"; }
        }
    }
}
