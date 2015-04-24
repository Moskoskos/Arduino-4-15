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
        public string temp = "";
        public ArduinoCom()
        {
            try
            {
                mySerialPort = new SerialPort(dbRead.GetComPort(1), 9600, Parity.None, 8, StopBits.One);
                string port = dbRead.GetComPort(1);//leser comport fra database
                mySerialPort.PortName = port;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find COM Port value. Make sure that the MySQL-server is running!");
            } 
        }
        private string _type;
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
            //string temp = "";
            //try
            //{
            //    if (mySerialPort.IsOpen)
            //    {
            //        temp = mySerialPort.ReadLine();
            //    }
            //    else
            //    {
            //        mySerialPort.Close();
            //        mySerialPort.Open();
            //        temp = mySerialPort.ReadLine();
                    
            //    }
            //    tempC = ((Convert.ToDouble(temp)) * 0.0318);

            //}
            //catch (Exception)
            //{
            //    comFault = true;
            //    tempC = -300;
            //}
            return Math.Round(tempC, 2);
        }

        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            //indata = sp.ReadExisting();
            temp = mySerialPort.ReadLine();            
            tempC = ((Convert.ToDouble(temp)) * 0.0318);
        }

    }
}
