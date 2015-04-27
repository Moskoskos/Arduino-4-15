using System;
using System.Windows.Forms;
using System.IO.Ports;


namespace CTS_Application
{
    class ArduinoCom
    {
        DbRead dbRead = new DbRead();
        SerialPort mySerialPort;
        Timer tmrCom = new Timer(); 
        public bool comFault{get; set;}
        public double tempC = 0.0;
        public string oldTemp = "";
        public string temp = "";
        public int timeOut = 0;
       

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
       
        public double Readtemp()
        {
            tmrCom.Interval = 1000;
            tmrCom.Start();
           
            if (timeOut > 4)//hvis timeoutverdi overstiger 4 blir comfault satt og -300 returneres isedenfor temp
            {
                comFault = true;
                tempC = -300.0;
            }

            return Math.Round(tempC, 2);
        }

        // Event som intreffer hvis programmet mottar noe fra comport
        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            timeOut = 0;//Timeoutverdi blir satt til 0 hver gang data mottas
            comFault = false;
            temp = mySerialPort.ReadLine();//leser verdi fra arduino
            tempC = ((Convert.ToDouble(temp)) * 0.0318);//gjør om til grader celsius                    
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timeOut += 1 ;//teller opp timeoutverdi 1 gang per sek
        }
    }
    //kilde: https://msdn.microsoft.com/en-us/library/system.io.ports.serialport%28v=vs.110%29.aspx
    //SerialPort class msdn
}
