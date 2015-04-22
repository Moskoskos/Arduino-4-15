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
using System.Diagnostics;


namespace CTS_Application
{
    public partial class frmMain : Form
    {
        double temp_Arduino = 0.0;        
       
        DbConnect con = new DbConnect();
        DbWrite dbWrite = new DbWrite();
        DbRead dbRead = new DbRead();
        DbEdit dbEdit = new DbEdit();
        ArduinoCom arCom = new ArduinoCom();
        AlarmHandling alarm = new AlarmHandling();
        Email mail = new Email();
        BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); //Declare batterymonitoring class
        System.Timers.Timer tmrAlarm = new System.Timers.Timer(); //Timer to monitor alarm events.
        System.Timers.Timer tmrRecToDb = new System.Timers.Timer(); //Timer to record temperature recordings to database.
       
        public frmMain()
        {
            InitializeComponent();
           tmrUpdateGui.Start();
           cbRealtimeUnit.SelectedIndex = 1;
           tmrAlarmInit();  //Innstillingene til timeren.
           tmrAlarm.Start(); //Start timeren.
           tmrRecToDbInit(); //Innstillingene til timeren.
           tmrRecToDb.Start(); //Start timeren.
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateGraph(); 
            UpdateAlarmGrid();           
        }
        /// <summary>
        /// Innstillingene til tmrAlarm.
        /// </summary>
        private void tmrAlarmInit()
        {
            tmrAlarm.Interval = 3000; // Interval = 3 Sekunder.
            tmrAlarm.Elapsed += tmrAlarm_Elapsed; // Etter 3 sekunder skal en hendelse skje.
            tmrAlarm.AutoReset = true; // Reseter timeren etter at timeren har kalt hendelsen.
        }

        //tmrAlarm_eventet 
        void tmrAlarm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckAlarmStatus(); //Henter metoden som sjekker om det finnes noen aktive alarmer.
        }
        //
        private void tmrUpdateGui_Tick(object sender, EventArgs e)
        {
            BatteryRemaining(); //PATRICK !
            MemoryUsage(); //Viser den fysiske minnebruken til applikasjonen.
            MySqlStatus(); //Sjekker om DatabaseServeren kjører.
            UpdateTemp(); //Oppdaterer temperaturverdien i frmMain fra klassen arduinoCOM.
        }
        private void tmrRecToDbInit()
        {
            tmrRecToDb.Interval = 4000; 
            tmrRecToDb.Elapsed +=tmrRecToDb_Elapsed;
            tmrRecToDb.AutoReset = true;
        }

        void tmrRecToDb_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            RecordToDatabase();
            Invoke((MethodInvoker)delegate { UpdateGraph(); }); //Denne metoden gjør at programmet henger seg i 0.5s hvert interval.

        }
        public void UpdateGraph()
        {
            // TODO: This line of code loads data into the 'dataSetToGrah.historian' table. You can move, or remove it, as needed.
            this.historianTableAdapter.Fill(this.dataSetToGrah.historian);
            //Update chart with temp
            chrtTemp.DataBind();
            chrtTemp.Refresh();

        }
        public void UpdateAlarmGrid()
        {
            // TODO: This line of code loads data into the 'dataSetAlarmEvents.alarm_historian' table. You can move, or remove it, as needed.
            this.alarm_historianTableAdapter.Fill(this.ctsDataSetAlarm.alarm_historian);
        }

        private void btnSubView_Click_1(object sender, EventArgs e)
        {
            DateTime temp = dateTimePicker1.Value;
            DateTime temp2 = dateTimePicker2.Value;
         
                if (temp.ToOADate() > temp2.ToOADate())
                {
                    MessageBox.Show("Cannot have a start date later than the end date.");
                }
                else
                {
                    chrtTemp.ChartAreas[0].AxisX.Minimum = temp.ToOADate();
                    chrtTemp.ChartAreas[0].AxisX.Maximum = temp2.ToOADate();
                }

            }
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings SettingsWindow = new frmSettings();
            SettingsWindow.Show();
        }
        private void MySqlStatus()
        {
            Process[] instance = Process.GetProcessesByName("mysqld");
            tslblDBStat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right; //Right alignment.
            if (instance.Length != 0)
            {
                tslblDBStat.Text = "Running";
            }
            else
            {
                tslblDBStat.Text = "Stopped";
            }
        }

        private void RecordToDatabase()
        {
            try
            {
                if (temp_Arduino == -300)
                {
                    
                }
                else
                {
                    //write temp to db
                 dbWrite.WriteTempToHistorian(temp_Arduino);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MemoryUsage()
        {
            //Displays the programs current memory Usage. 
            //Source:
            //http://stackoverflow.com/questions/1440720/how-can-i-determine-how-much-memory-my-program-is-currently-occupying
            //
            long memory = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;

            tslblRAM.Text  =(memory / 1024 / 1024).ToString() + "MB"; 
        }
        private void UpdateTemp()
        {
            try
            {
                if (arCom.comFault == false)
                {
                    temp_Arduino = arCom.Readtemp();
                    if (temp_Arduino == -300)
                    {
                        lblCV.Text = "NO INPUT";
                    }
                    else
                    {
                        lblCV.Text = Convert.ToString(temp_Arduino) + "°C";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BatteryRemaining()
        {
            BatteryMonitoring batteryMonitoring = new BatteryMonitoring();
            tslblBat.Text = batteryMonitoring.PercentBatteryLeft.ToString() +"%";
            //To disable animation, decrement progress bar.
            if (batteryMonitoring.PercentBatteryLeft < tsprgBat.Maximum)
            {
                tsprgBat.Value = batteryMonitoring.PercentBatteryLeft + 1;
            }
            
            tsprgBat.Value = batteryMonitoring.PercentBatteryLeft;

            tslblState.Text = batteryMonitoring.Status;

        }

        private void subscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subscribers sub = new Subscribers();
            sub.Show();
        }
        private void CheckAlarmStatus()
        {
            bool highTemp;
            bool lowTemp;
            bool tempOOR;
            bool batAlarm;
            bool arcomAlarm;
            double spH = Convert.ToDouble(dbRead.GetHighSp(1));
            double spL = Convert.ToDouble(dbRead.GetLowSP(1));
            double realTemp = realTemp = arCom.Readtemp();

            highTemp = alarm.HighTempAlarm(spH, realTemp);
            lowTemp = alarm.LowTempAlarm(spL, realTemp);
            tempOOR = alarm.TempOutOfRange(realTemp);
            batAlarm = alarm.BatteryAlarm(batteryMonitoring.StatusChanged());
            arcomAlarm = alarm.ArduComAlarm(arCom.comFault);


            if (highTemp == true)
            {
                string message = "Temperature extended setpoint: High (" + spH + "°C). Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(1, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if ((lowTemp == true) && (arcomAlarm == false))
            {
                string message = "Temperature extended setpoint: Low (" + spL + "°C). Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(2, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if ((tempOOR == true) && (arcomAlarm == false))
            {
                string message = "Temperature out of range. Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(3, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if (batAlarm == true)
            {
                string message = "Lost powerline. Laptop is running on battery";
                dbWrite.WriteToAlarmHistorian(4, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            } 
            if (arcomAlarm == true)
            {
                string message = "Lost Connection to Arduino";
                dbWrite.WriteToAlarmHistorian(5, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
                MessageBox.Show("The program could not find the Arduino. Go to Preferences to change COM port");
            }
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime temp = dateTimePicker1.Value;
            DateTime temp2 = dateTimePicker2.Value;

            if (temp.ToOADate() > temp2.ToOADate())
            {
                MessageBox.Show("Cannot have a start date later than the end date.");
            }
            else
            {
                chrtTemp.ChartAreas[0].AxisX.Minimum = temp.ToOADate();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime temp = dateTimePicker1.Value;
            DateTime temp2 = dateTimePicker2.Value;
            if (temp.ToOADate() > temp2.ToOADate())
            {
                MessageBox.Show("Cannot have a start date later than the end date.");
            }
            else
            {
                chrtTemp.ChartAreas[0].AxisX.Maximum = temp2.ToOADate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
