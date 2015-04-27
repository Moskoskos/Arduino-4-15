using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;


namespace CTS_Application
{
    public partial class frmMain : Form
    {
        double temp_Arduino = 0.0;

        //  DbConnect con = new DbConnect();
        DbWrite dbWrite = new DbWrite();
        DbRead dbRead = new DbRead();
        DbEdit dbEdit = new DbEdit();
        ArduinoCom arCom = new ArduinoCom();
        AlarmHandling alarm = new AlarmHandling();
        Email mail = new Email();
        BatteryMonitoring batteryMonitoring = new BatteryMonitoring(); //Declare batterymonitoring class
        System.Timers.Timer tmrAlarm = new System.Timers.Timer(); //Timer to monitor alarm events.
        System.Timers.Timer tmrRecToDb = new System.Timers.Timer(); //Timer to record temperature recordings to database.
        System.Timers.Timer tmrTest = new System.Timers.Timer();//testing

        public frmMain()
        {
            InitializeComponent();
            tmrUpdateGui.Start();
            //Initialize GUI time ranges
            cboRealtimeRange.SelectedIndex = 12 - 1; //12 hours initial range.
            cboRealtimeUnit.SelectedIndex = 1; //hours initial unit.
            dtpHistoryEnd.Value = DateTime.Now;
            dtpHistoryStart.Value = DateTime.Now.AddMonths(-1); //One month initial range.


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

        private void tmrAlarmInit()
        {
            tmrAlarm.Interval = 3000; // Interval = 3 Sekunder.
            tmrAlarm.Elapsed += tmrAlarm_Elapsed; // Etter 3 sekunder skal en hendelse skje.
            tmrAlarm.AutoReset = true; // Reseter timeren etter at timeren har kalt hendelsen.
        }

        //tmrAlarm_Elapsed kjører ved hvert tikk
        void tmrAlarm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckAlarmStatus(); //Henter metoden som sjekker om det finnes noen aktive alarmer.
        }

        private void tmrUpdateGui_Tick(object sender, EventArgs e)
        {
            try
            {
                BatteryRemaining(); //Viser tid igjen før batteriet er tomt
                MemoryUsage(); //Viser den fysiske minnebruken til applikasjonen.
                MySqlStatus(); //Sjekker om DatabaseServeren kjører.
                UpdateTemp(); //Oppdaterer temperaturverdien i frmMain fra klassen arduinoCOM.
                if (rbtnRealtime.Checked)
                {
                    UpdateRange(); //Oppdaterer range til graf i realtime.
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        /// <summary>
        /// Innstillinger for timer som skal skrive til database
        /// </summary>
        private void tmrRecToDbInit()
        {
            tmrRecToDb.Interval = 4000;
            tmrRecToDb.Elapsed += tmrRecToDb_Elapsed;
            tmrRecToDb.AutoReset = true;
        }

        void tmrRecToDb_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            RecordTempToDatabase();
            Invoke((MethodInvoker)delegate { UpdateGraph(); }); //Denne metoden gjør at programmet henger seg i 0.5s hvert interval.

        }
        /// <summary>
        /// Metode som oppdaterer grafen med data fra databasen
        /// </summary>
        public void UpdateGraph()
        {
            // TODO: This line of code loads data into the 'dataSetToGrah.historian' table. You can move, or remove it, as needed.
            this.historianTableAdapter.Fill(this.dataSetToGrah.historian);
            //Update chart with temp
            chrtTemp.DataBind();
            chrtTemp.Refresh();

        }
        /// <summary>
        /// Metode som oppdaterer alarmliste fra databasen
        /// </summary>
        public void UpdateAlarmGrid()
        {
            // TODO: This line of code loads data into the 'dataSetAlarmEvents.alarm_historian' table. You can move, or remove it, as needed.
            this.alarm_historianTableAdapter.Fill(this.ctsDataSetAlarm.alarm_historian);
        }


        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings SettingsWindow = new frmSettings();
            SettingsWindow.Show();
        }
        //Source:
        //https://msdn.microsoft.com/en-us/library/z3w4xdc9(v=vs.110).aspx
        //
        /// <summary>
        /// Metode som skjekker om databasen kjører eller ikke
        /// </summary>
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
        /// <summary>
        /// Metode som skriver teperaturverdier til databasen
        /// </summary>
        private void RecordTempToDatabase()
        {
            try
            {
                if (temp_Arduino != -300)
                {
                    dbWrite.WriteTempToHistorian(temp_Arduino);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metode brukt for å hente opp den totale minnemengden programmet og mysql bruker.
        /// </summary>
        private void MemoryUsage()
        {
            //Displays the programs current physical memory Usage. 
            //Source:
            //https://msdn.microsoft.com/en-us/library/system.diagnostics.process.workingset64(v=vs.110).aspx
            //2nd Source:
            //http://stackoverflow.com/questions/1440720/how-can-i-determine-how-much-memory-my-program-is-currently-occupying
            //
            Process[] usage = System.Diagnostics.Process.GetProcessesByName("mysqld"); //Henter informasjonen om processen med det tilhørende navnet.
            long mySqlMem = usage[0].WorkingSet64; //Henter informasjon om hvor mye fysisk minne prosessen bruker.
            long memory = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64; //Henter informasjon om hvor mye fysisk minne prosessen bruker.
            tslblRAM.Text = "CTMS: " + (memory / 1024 / 1024).ToString() + " MB" + " / Database: " + (mySqlMem / 1024 / 1024).ToString() + " MB";  //Info til statusbar.
        }
        /// <summary>
        /// Metode som oppdaterer temepraturvisning av siste temp verdi og vises i frmMain
        /// </summary>
        private void UpdateTemp()
        {
            try
            {
                temp_Arduino = arCom.Readtemp();
                if (temp_Arduino == -300.0)
                {
                    lblCV.Text = "NO INPUT";
                }
                else
                {
                    lblCV.Text = Convert.ToString(temp_Arduino) + "°C";
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
            tslblBat.Text = batteryMonitoring.PercentBatteryLeft.ToString() + "%";
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
            //Deklarerer variabler.
            bool highTemp;
            bool lowTemp;
            bool tempOOR;
            bool batAlarm;
            bool arcomAlarm;
            bool batteryAlarm;
            // Gir verdier til variabler.
            double spH = Convert.ToDouble(dbRead.GetHighSp(1));
            double spL = Convert.ToDouble(dbRead.GetLowSP(1));
            double realTemp = realTemp = arCom.Readtemp();
            int spLBattery = 40;
            int batteryPercent = batteryMonitoring.PercentBatteryLeft;
            double timeLeft = batteryMonitoring.TimeLeft;
            //Kaller opp metoder i alarmklassen og sender med parametere. Returnerer true eller false utifra verdier.
            highTemp = alarm.HighTempAlarm(spH, realTemp);
            lowTemp = alarm.LowTempAlarm(spL, realTemp);
            tempOOR = alarm.TempOutOfRange(realTemp);
            batAlarm = alarm.BatteryAlarm(batteryMonitoring.StatusChanged());
            arcomAlarm = alarm.ArduComAlarm(arCom.comFault);
            batteryAlarm = alarm.LowBatteryPercent(spLBattery, batteryPercent, batAlarm);

            //Her sjekkes verdien til variablene. Hvis der "true" vil det skrives en alarm til databasen og det vil sendes en mail.
            //Til slutt oppdateres AlarmGrid.
            if (highTemp)
            {
                string message = "Temperature extended setpoint: High (" + spH + "°C). Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(1, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if ((lowTemp) && (arcomAlarm == false))
            {
                string message = "Temperature extended setpoint: Low (" + spL + "°C). Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(2, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if ((tempOOR) && (arcomAlarm == false))
            {
                string message = "Temperature out of range. Temperature =" + realTemp.ToString() + "°C";
                dbWrite.WriteToAlarmHistorian(3, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if (batAlarm)
            {
                string message = "Lost powerline. Laptop is running on battery";
                dbWrite.WriteToAlarmHistorian(4, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
            }
            if (arcomAlarm)
            {
                string message = "Lost Connection to Arduino";
                dbWrite.WriteToAlarmHistorian(5, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
                MessageBox.Show("The program could not find the Arduino. Go to Preferences to change COM port");
            }
            if (batteryAlarm)
            {
                string message = ("Low Battery percent. " + timeLeft + " minuttes until system shut down" + batteryPercent + "% left");
                dbWrite.WriteToAlarmHistorian(6, message);
                mail.SendMessage(message);
                this.Invoke((MethodInvoker)delegate { UpdateAlarmGrid(); });
                MessageBox.Show("Low Battery percent. " + timeLeft + " minuttes until system shut down" + batteryPercent + "% left. Connect charger");
            }
        }

        private void UpdateRange()
        {
            DateTime end = DateTime.Now;
            DateTime start = DateTime.Now;

            //Realtime mode selected
            if (rbtnRealtime.Checked)
            {
                //Disable and enable controls.
                cboRealtimeRange.Enabled = true;
                cboRealtimeUnit.Enabled = true;
                dtpHistoryStart.Enabled = false;
                dtpHistoryEnd.Enabled = false;

                //Calculate the range to DateTime format
                int minutes = cboRealtimeRange.SelectedIndex + 1;
                if (cboRealtimeUnit.SelectedIndex >= 1) //minutes to hours
                {
                    minutes *= 60;
                    if (cboRealtimeUnit.SelectedIndex >= 2) //hours to days
                    {
                        minutes *= 24;
                    }
                }


                //Set end and start of range.
                end = DateTime.Now;
                start = end.AddMinutes((float)(minutes * -1)); //Add the negative number of minutes to subtract from current time.

            }

            //History mode selected
            else if (rbtnHistory.Checked)
            {

                //Disable and enable controls.
                cboRealtimeRange.Enabled = false;
                cboRealtimeUnit.Enabled = false;
                dtpHistoryStart.Enabled = true;
                dtpHistoryEnd.Enabled = true;

                if (dtpHistoryEnd.Value > DateTime.Now)
                {
                    MessageBox.Show("End date is greater than todays date");
                    dtpHistoryEnd.Value = DateTime.Now;
                }
                if (dtpHistoryStart.Value >= dtpHistoryEnd.Value)
                {
                    dtpHistoryStart.Value = dtpHistoryEnd.Value.AddDays(-1);
                    MessageBox.Show("Start date must be set earlier than end date");
                }
                else
                {
                    end = dtpHistoryEnd.Value;
                    start = dtpHistoryStart.Value;
                }
            }
            //No range mode selected
            else
            {
                MessageBox.Show("No time range is set");
                start = DateTime.Now;
                end = DateTime.Now;
            }

            //Set the label format
            if (((end - start).Days) > 5)
            {
                chrtTemp.ChartAreas["Temperature"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            }
            else if (((end - start).Days) > 1)
            {
                chrtTemp.ChartAreas["Temperature"].AxisX.LabelStyle.Format = "dd/MM/yy - HH:mm";
            }
            else
            {
                chrtTemp.ChartAreas["Temperature"].AxisX.LabelStyle.Format = "HH:mm";
            }

            //Write the range to the charting component.
            chrtTemp.ChartAreas[0].AxisX.Minimum = start.ToOADate();
            chrtTemp.ChartAreas[0].AxisX.Maximum = end.ToOADate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

        private void rbtnRealtime_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

        private void rbtnHistory_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

        private void cboRealtimeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

        private void cboRealtimeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRange();
        }

    }
}
