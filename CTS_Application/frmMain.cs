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
        
        public frmMain()
        {
            
            InitializeComponent();
            //Declare batterymonitoring class
            BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); 
            //show percentage left in label.
            lblPercentage.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "% available"; 
            //Checks whether the battery status can be read or not. If -1 then no. 
            if (batteryMonitoring.TimeLeft > 0) 
            {
                lblTimeLeft.Text = batteryMonitoring.TimeLeft.ToString();
            }
            else
            {
                lblTimeLeft.Text = "System could not calculate remaining time. Driver missing!";
            }
            lblState.Text = batteryMonitoring.Status;
            //Simulate temp
            tmrSimTemp.Start();
            if (days == (3*365))
            {
                tmrSimTemp.Stop();
            }
            tmrRecToDb.Start();
            
        }
        //Opens the subscriber window
        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            frmSub sub = new frmSub();
            sub.Show();
        }
        //Ever x-interval the program retrieves the system information related to battery status
        //default: Every 30 second.
        private void tmrStatusChanged_Tick(object sender, EventArgs e)
        {
            BatteryMonitoring batteryMonitoring = new BatteryMonitoring();
            lblPercentage.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "% available";
            if (batteryMonitoring.TimeLeft >= 1)
            {
                lblTimeLeft.Text = batteryMonitoring.TimeLeft.ToString();
            }
            else
            {
                lblTimeLeft.Text = "System could not calculate remaining time.";
            }
            lblState.Text = batteryMonitoring.Status;
        }
      

       private void tmrSimTemp_Tick(object sender, EventArgs e)
       {
           temp_Arduino = arcom.Temperature(days);
           txtCV.Text = Convert.ToString(temp_Arduino);
           days = days + 1;
       }

       private void btnSubmit_Click(object sender, EventArgs e)
       {
           int setPoint = Convert.ToInt32(txtSpL.Text);
           int hysteresis = Convert.ToInt32(txtHysteresis.Text);
           dbConGlob.ChangeSetPoint(setPoint, hysteresis);
       }

       private void tmrRecToDb_Tick(object sender, EventArgs e)
       {
           try
           {
               //write temp to db
               dbConGlob.WriteTempemperatureToHistorian(temp_Arduino);
               // Update chart with temp
               this.historianTableAdapter.Fill(this.ctsDataSetDbHistorianToGraph.historian);
               this.chrtTemp.Update();
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               tmrRecToDb.Stop();
           }
       }

       private void frmMain_Load(object sender, EventArgs e)
       {
           // TODO: This line of code loads data into the 'ctsDataSetDbHistorianToGraph.historian' table. You can move, or remove it, as needed.
           this.historianTableAdapter.Fill(this.ctsDataSetDbHistorianToGraph.historian);
           // TODO: This line of code loads data into the 'ctsDataSetHistorian.alarm_historian' table. You can move, or remove it, as needed.
           //http://stackoverflow.com/questions/12033448/how-to-connect-two-different-windows-forms-keeping-both-open
           //Where to place the window at startup
           this.Location = new Point(0, 0);
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

        //This is for testing purposes only!

       private void button1_Click(object sender, EventArgs e)
       {
           dbConGlob.WriteToAlarmHistorian(1, "Do");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button2_Click(object sender, EventArgs e)
       {
           dbConGlob.WriteToAlarmHistorian(2, "You");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button3_Click(object sender, EventArgs e)
       {
           dbConGlob.WriteToAlarmHistorian(3, "Wanna");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button4_Click(object sender, EventArgs e)
       {
           dbConGlob.WriteToAlarmHistorian(4,"PLAY DUNGEON MASTER?");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button5_Click(object sender, EventArgs e)
       {
           dbConGlob.WriteToAlarmHistorian(5, ":D");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }
    }
}
