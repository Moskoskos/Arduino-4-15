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
        DbConnect con = new DbConnect();
        ArduinoCom arCom = new ArduinoCom();
        AlarmHandling alarm = new AlarmHandling();
        BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); //Declare batterymonitoring class
        public frmMain()
        {
            InitializeComponent();
            Status();
            tmrStatus.Start();
            tmrRecToDb.Start();
            tmrSimTemp.Start();
            
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
           txtSpL.Text = con.GetLowSP(1);
           txtSpH.Text = con.GetHighSp(1);
           
        }

        //Opens the subscriber window
        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            Subscribers sub = new Subscribers();
            sub.Show();
        }

       private void tmrSimTemp_Tick(object sender, EventArgs e)
       {
           temp_Arduino = arCom.Readtemp();
           lblCV.Text = Convert.ToString(temp_Arduino) + "°C";
           days = days + 2;
       }

       private void btnSubmit_Click(object sender, EventArgs e)
       {
           try
           {
               int setPointLow = Convert.ToInt32(txtSpL.Text);
               int setPointHigh = Convert.ToInt32(txtSpH.Text);
               con.ChangeSetPoint(1, setPointLow, setPointHigh);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       private void tmrRecToDb_Tick(object sender, EventArgs e)
       {
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
       private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
       {
           
           chrtTemp.ChartAreas["Series1"].AxisX.Minimum = 0;
       }
       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
       {
          // var temp = dateTimePicker1.Value;
           //chrtTemp.ChartAreas["Series1"].AxisX.Maximum = temp;
           //test test
       }

       private void menuSettings_Click(object sender, EventArgs e)
       {
           frmSettings SettingsWindow = new frmSettings();
           SettingsWindow.Show();
       }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            //Simulate temp
            //tmrReadTempArd.Start();
           // if (days == (3 * 365)) { tmrReadTempArd.Stop(); }
           // tmrRecToDb.Start();
        }

        private void btnStopSim_Click(object sender, EventArgs e)
        {
            tmrSimTemp.Stop();
            tmrRecToDb.Stop();
        }

        private void tmrStatus_Tick(object sender, EventArgs e)
        {
            Status();
        }
        private void Status()
        {
            BatteryMonitoring batteryMonitoring = new BatteryMonitoring();
            lblPercentage.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "% available";
            if (batteryMonitoring.TimeLeft >= 1) { lblTimeLeft.Text = batteryMonitoring.TimeLeft.ToString(); }
            else { lblTimeLeft.Text = "System could not calculate remaining time. Driver missing"; }
            lblState.Text = batteryMonitoring.Status;
            //Displays the programs current memory Usage. 
            //Source:
            //http://stackoverflow.com/questions/1440720/how-can-i-determine-how-much-memory-my-program-is-currently-occupying
            //
            long memory = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
            if (memory > 1048576) { lblMemory.Text = "Memory usage: " + (memory / 1024 / 1024).ToString() + "MB"; }
            else { lblMemory.Text = "Memory usage: " + (memory / 1024).ToString() + "KB"; }
        }

        private void tmrAlarm_Tick(object sender, EventArgs e)
        {
            bool highTemp = false;
            bool lowTemp = false;
            bool tempOOR = false;
            bool batAlarm = false;
            bool arcomAlarm = false;
            double spH = Convert.ToDouble(con.GetHighSp(1));
            double spL = Convert.ToDouble(con.GetLowSP(1));
            double realTemp = arCom.Readtemp();

            highTemp = alarm.HighTempAlarm(spH, realTemp);
            lowTemp = alarm.LowTempAlarm(spL, realTemp);
            tempOOR = alarm.TempOutOfRange(realTemp);
            batAlarm = alarm.BatteryAlarm(batteryMonitoring.StatusChanged());
            arcomAlarm = alarm.ArduComAlarm(arCom.ComFault());

            if (highTemp == true)
            {
                con.WriteToAlarmHistorian(1, "Temperature extended setpoint: High. PV =" + realTemp.ToString());
            }
            if (lowTemp ==true)
            {
                con.WriteToAlarmHistorian(2, "Temperature extended setpoint: Low. PV =" + realTemp.ToString());
            }
            if (tempOOR == true)
            {
                con.WriteToAlarmHistorian(3, "Temperature out of range. PV=" + realTemp.ToString());
            }
            if (batAlarm == true)
            {
                con.WriteToAlarmHistorian(4, "Lost powerline. Laptop on battery");
            }
            if (arcomAlarm == true)
            {
                con.WriteToAlarmHistorian(5, "Lost connection to Arduino");
            }
        }




    }
}
