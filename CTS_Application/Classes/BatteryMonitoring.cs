    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace CTS_Application
{
    public partial class BatteryMonitoring
    {
        //Get powerStatus class for monitoring
        PowerStatus power = SystemInformation.PowerStatus;
        
        int powerPercent;
        string powerStatus;
        int timeLeft;

        public BatteryMonitoring()
        {

         }
        public int PercentBatteryLeft
        {
            get
            {
               powerPercent = Convert.ToInt32(power.BatteryLifePercent *100);
               return powerPercent;
            }
        }
        public string Status
        {
            get
            {
               powerStatus = power.PowerLineStatus.ToString();
               if (power.PowerLineStatus.ToString() == "Online")
               {
                   powerStatus = "Laptop is charging";
               }
               else
               {
                   powerStatus = "Laptop is not charging";
               }
               return powerStatus;
            }
        }
        public double TimeLeft
        {
             get
            {

                 //test test. remove 14.04
                 //test 2 
               timeLeft = power.BatteryLifeRemaining / 60 ;
                 return timeLeft;
            }
        }
     public bool StatusChanged()
     {
         bool powerDisconnected = false ;
         

         if ( System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
         {
             powerDisconnected = true;
         }
         if(System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
         {
             powerDisconnected = false;
         }
         return powerDisconnected;

     } 
}
 
}
     
    
   


