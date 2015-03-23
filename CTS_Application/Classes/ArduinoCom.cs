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
        SerialPort mySerialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
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
                }
                else
                {
                    mySerialPort.Open();
                    temp = mySerialPort.ReadLine();
                }
                tempC = (Convert.ToDouble(temp)) / 9.31;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comFault = true;
            }
            return Math.Round(tempC, 2);
        }
        public bool ComFault()
        {
            bool fault = comFault;
            return fault;
        }
        public bool TempOutOfRange()
        {
            bool fault = false;
            if ((temp < -20.0) || (temp > 50.0))
            {
                fault = true;
            }
            return fault;
        }


        //Simulates the temperature variation throughout one year ranging from -20*C to +20*C
        public double Temperature(double days)
        {
            double temp = 0.0;
            double x = days;
            temp = (20 * Math.Cos(((2 * Math.PI * x) / 365) - ((80 * Math.PI) / 73) + 13));
            temp = Math.Round(temp, 1);
            return temp;


        }




    }
}
