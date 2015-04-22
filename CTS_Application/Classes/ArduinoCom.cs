using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CTS_Application
{
    class ArduinoCom
    {
        DbRead dbRead = new DbRead();
        public bool comFault{get; set;}
        SerialPort mySerialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
        public double tempC = 0.0;

        public ArduinoCom()
        {
            try
            {
                string port = "COM" + dbRead.GetComPort(1);//leser comport fra database
                mySerialPort.PortName = port;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find COM Port value. Make sure that the MySQL-server is running!");
            } 
        }
        /// <summary>
        /// Metode som leser verdi fra comport, ganger med 0,0318 for å få temp, setter comFault true ved feil
        /// </summary>
        /// <returns>Returnerer temperatur</returns>
        public double Readtemp()
        {
            string temp = "";
            try
            {
                if (mySerialPort.IsOpen)
                {
                    temp = mySerialPort.ReadLine();
                }
                else
                {
                    mySerialPort.Open();
                    temp = mySerialPort.ReadLine();
                    
                }
                tempC = ((Convert.ToDouble(temp)) * 0.0318);

            }
            catch (Exception)
            {
                comFault = true;
                tempC = -300;
            }
            return Math.Round(tempC, 2);
        }
    }
}
