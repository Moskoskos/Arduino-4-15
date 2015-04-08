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
            chrtTemp.ChartAreas[0].AxisX.ScaleView.Zoomable = true;


        }
        //Opens the subscriber window
        private void btnSubscribers_Click(object sender, EventArgs e)
        {
            Subscribers sub = new Subscribers();
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
               this.historianTableAdapter.Fill(this.ctsDataSetDbHistorianToGraph.historian);
               
               this.chrtTemp.Update();
               
           }
           catch (Exception ex)
           {
               tmrRecToDb.Stop();
               MessageBox.Show(ex.Message);
               
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
           alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

        //This is for testing purposes only!

       private void button1_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           con.WriteToAlarmHistorian(1, "Do");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button2_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           con.WriteToAlarmHistorian(2, "You");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button3_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           con.WriteToAlarmHistorian(3, "Wanna");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button4_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           con.WriteToAlarmHistorian(4,"PLAY DUNGEON MASTER?");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }

       private void button5_Click(object sender, EventArgs e)
       {
           DbConnect con = new DbConnect();
           con.WriteToAlarmHistorian(5, ":D");
           this.alarm_historianTableAdapter.Fill(this.ctsDataSetHistorian.alarm_historian);
       }


        //Attempt scrolling in chart arena
        //Source
       //http://stackoverflow.com/questions/13584061/how-to-enable-zooming-in-microsoft-chart-control-by-using-mouse-wheel
        //
       private void chrtTemp_MouseWheel(object sender, MouseEventArgs e)
       {
           try
           {
               if (e.Delta < 0)
               {
                   chrtTemp.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                   chrtTemp.ChartAreas[0].AxisY.ScaleView.ZoomReset();
               }

               if (e.Delta > 0)
               {
                   double xMin = chrtTemp.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                   double xMax = chrtTemp.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                   double yMin = chrtTemp.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                   double yMax = chrtTemp.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                   double posXStart = chrtTemp.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                   double posXFinish = chrtTemp.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                   double posYStart = chrtTemp.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                   double posYFinish = chrtTemp.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                   chrtTemp.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                   chrtTemp.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
               }
           }
           catch { }
       }

       private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
       {

       }
    }
}
