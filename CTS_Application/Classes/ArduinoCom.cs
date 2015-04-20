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
        public bool comFault;
        SerialPort mySerialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
        public double tempC = 0.0;

        public ArduinoCom()
        {
            try
            {
                string port = "COM" + dbRead.GetComPort(1);
                mySerialPort.PortName = port;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find COM Port value. Make sure that the MySQL-server is running!");
            } 
        }
        /// <summary>
        /// Metode som leser verdi fra comport, deler på 9,31 for å få temp
        /// </summary>
        /// <returns></returns>
        public double Readtemp()
        {
            string temp = "";
            //double tempC = 0.0;
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
                //MessageBox.Show("feil ved avlesning av temperatur");
                tempC = -300;
            }
            return Math.Round(tempC, 2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ComFault()
        {
            bool fault = comFault;
            return fault;
        } 
    }
}
