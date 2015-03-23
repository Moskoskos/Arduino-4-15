using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_Application
{
   class ArduinoCom
    {
       public ArduinoCom()
       {

       }
     
       
       //Simulates the temperature variation throughout one year ranging from -20*C to +20*C
        public double Temperature(double days)
        {
                double temp = 0.0;
                double x = days;
            temp = (20*Math.Cos(((2*Math.PI*x)/365)-((80*Math.PI)/73)+13));
            temp = Math.Round(temp, 1);
            return temp;
          
          
        }
     
        
   
    }
}
