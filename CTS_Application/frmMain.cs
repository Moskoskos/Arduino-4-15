﻿using System;
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
       
        DbConnect con = new DbConnect();
        DbWrite dbWrite = new DbWrite();
        DbRead dbRead = new DbRead();
        DbEdit dbEdit = new DbEdit();
        
        ArduinoCom arCom = new ArduinoCom("COM3");
        AlarmHandling alarm = new AlarmHandling();
        Email mail = new Email();
        BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); //Declare batterymonitoring class
       
        public frmMain()
        {
            InitializeComponent();
            Status();
            tmrStatus.Start();
            tmrRecToDb.Start();
            tmrTemp.Start();
           // tmrAlarm.Start();
            // See btnSim_tick for reasoning. Like...Things why we do the things we do. 
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtSpL.Text = dbRead.GetLowSP(1);
            txtSpH.Text = dbRead.GetHighSp(1);
            // TODO: This line of code loads data into the 'dataSetToGrah.historian' table. You can move, or remove it, as needed.
            this.historianTableAdapter.Fill(this.dataSetToGrah.historian);
            // TODO: This line of code loads data into the 'dataSetAlarmEvents.alarm_historian' table. You can move, or remove it, as needed.
            UpdateAlarmGrid();           
            //Source:
            //http://stackoverflow.com/questions/12033448/how-to-connect-two-different-windows-forms-keeping-both-open
            //Where to place the window at startup
           
          
            
           
        }

        //Opens the subscriber window
        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            Subscribers sub = new Subscribers();
            sub.Show();
        }

       private void tmrTemp_Tick(object sender, EventArgs e)
       {
           if (arCom.comFault == true)
           {
               tmrTemp.Stop();
               MessageBox.Show("The program could not find the Arduino. Go to Preferences to change COM port");
           };
           temp_Arduino = arCom.Readtemp();
           lblCV.Text = Convert.ToString(temp_Arduino) + "°C";
       }

       private void btnSubmit_Click(object sender, EventArgs e)
       {
           try
           {
               dbWrite.WriteToAlarmHistorian(1, "Temperature extended setpoint: High. PV =");
               int setPointLow = Convert.ToInt32(txtSpL.Text);
               int setPointHigh = Convert.ToInt32(txtSpH.Text);
               dbEdit.ChangeSetPoint(1, setPointLow, setPointHigh);
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
               dbWrite.WriteTempemperatureToHistorian(temp_Arduino);
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

       private void btnStartAlarm_Click(object sender, EventArgs e)
        {
            /*
             * WARNING! WARNING
             * To prevent mails from firing off like a Palestinian milita during the liberation of Gaza.
             * REMOVE BEFORE FINAL VERSION
             */
            tmrAlarm.Start();
        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            /*
             * WARNING! WARNING
             * To prevent mails from firing off like a Palestinian milita during the liberation of Gaza.
             * REMOVE BEFORE FINAL VERSION
             */
            tmrAlarm.Stop();
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
            double spH = Convert.ToDouble(dbRead.GetHighSp(1));
            double spL = Convert.ToDouble(dbRead.GetLowSP(1));
            double realTemp = 0;
            realTemp = arCom.Readtemp();

            highTemp = alarm.HighTempAlarm(spH, realTemp);
            lowTemp = alarm.LowTempAlarm(spL, realTemp);
            tempOOR = alarm.TempOutOfRange(realTemp);
            batAlarm = alarm.BatteryAlarm(batteryMonitoring.StatusChanged());
            arcomAlarm = alarm.ArduComAlarm(arCom.ComFault());


            if (highTemp == true)
            {
                string message = "Temperature extended setpoint: High. Temperature =" + realTemp.ToString();
                dbWrite.WriteToAlarmHistorian(1, message);
                mail.SendMessage( message);
                UpdateAlarmGrid();
            }
            if (lowTemp ==true)
            {
                string message = "Temperature extended setpoint: Low. Temperature =" + realTemp.ToString();
                dbWrite.WriteToAlarmHistorian(2, message);
                mail.SendMessage( message);
                UpdateAlarmGrid();
            }
            if (tempOOR == true)
            {
                string message = "Temperature out of range. Temperature =" + realTemp.ToString();
                dbWrite.WriteToAlarmHistorian(3, message);
                mail.SendMessage( message);
                UpdateAlarmGrid();
            }
            if (batAlarm == true)
            {
                string message = "Lost powerline. Laptop is running on battery";
                dbWrite.WriteToAlarmHistorian(4, message);
                mail.SendMessage( message);
                UpdateAlarmGrid();
            }
            if (arcomAlarm == true)
            {
                string message = "Lost Connection to Arduino";
                dbWrite.WriteToAlarmHistorian(5, message);
                mail.SendMessage( message);
                UpdateAlarmGrid();
                
            }
        }
        public void UpdateAlarmGrid()
        {
            this.alarm_historianTableAdapter.Fill(this.dataSetAlarmEvents.alarm_historian);
        }
        public void SendAlarms()
        {

        }




    }
}
