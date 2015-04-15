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
        public bool comFault;
        public double temp { get; set; }
        SerialPort mySerialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
        public ArduinoCom(string initComPort)
        {
            mySerialPort.PortName = initComPort;
        }
        public ArduinoCom()
        {

        }
        //Metode som leser verdi fra comport, deler på 9,31 for å få temp
        public double Readtemp()
        {
            string temp = "";
            double tempC = 0.0;
            try
            {
                if (mySerialPort.IsOpen)
                {
                    temp = mySerialPort.ReadLine();
                    mySerialPort.Close();
                }
                else
                {
                    mySerialPort.Open();
                    temp = mySerialPort.ReadLine();
                    mySerialPort.Close();
                }
                tempC = ((Convert.ToDouble(temp)) * 0.0318);
            }
            catch (Exception)
            {
                comFault = true;               
            }
            return Math.Round(tempC, 2);
        }
        public bool ComFault()
        {
            bool fault = comFault;
            return fault;
        }
    }
}
