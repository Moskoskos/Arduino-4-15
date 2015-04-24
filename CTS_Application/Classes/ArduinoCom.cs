using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace CTS_Application
{
    class ArduinoCom
    {
        DbRead dbRead = new DbRead();
        public bool comFault{get; set;}
        SerialPort mySerialPort;
        public double tempC = 0.0;
        public string oldTemp = "";
        public string temp = "";
        public int timeOut = 0;
        Timer tmrCom = new Timer();        
        public ArduinoCom()
        {
            try
            {
                mySerialPort = new SerialPort(dbRead.GetComPort(1), 9600, Parity.None, 8, StopBits.One);
                string port = dbRead.GetComPort(1);//leser comport fra database
                mySerialPort.PortName = port;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Open();
                tmrCom.Tick += new EventHandler(timer_Tick);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find COM Port value. Make sure that the MySQL-server is running!");
            } 
        }
        
        public string ComPort
        {
            get { return mySerialPort.PortName; }
            set { mySerialPort.PortName = value; }
        }
        /// <summary>
        /// Metode som leser verdi fra comport, ganger med 0,0318 for å få temp, setter comFault true ved feil
        /// </summary>
        /// <returns>Returnerer temperatur</returns>
        public double Readtemp()
        {
            tmrCom.Interval = 1000;
            tmrCom.Start();
           
            if (timeOut > 4)
            {
                comFault = true;
                tempC = -300.0;
            }

            return Math.Round(tempC, 2);
        }
        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {

            timeOut = 0;
            comFault = false;
            temp = mySerialPort.ReadLine();
            tempC = ((Convert.ToDouble(temp)) * 0.0318);                    
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timeOut += 1 ;
        }
    }
}
