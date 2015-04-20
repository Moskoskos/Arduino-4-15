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
        
        string powerPercent;
        string powerStatus;
        int timeLeft;

        public BatteryMonitoring()
        {

         }
        /// <summary>
        /// 
        /// </summary>
        /// 
        //Viser batterikapasitet i PROSENT
        public string PercentBatteryLeft
        {
            get
            {
                powerPercent = "Battery at " + (power.BatteryLifePercent * 100).ToString() + "%";
               return powerPercent;
            }
        }
        /// <summary>
        /// 
        /// </summary>

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
        /// <summary>
        /// 
        /// </summary>
        //Viser gjennværende TID.
        public string TimeLeft
        {
             get
            {
               timeLeft = power.BatteryLifeRemaining / 60 ;
               if (timeLeft >= 1)
               {
                   return timeLeft.ToString();
               }
               else
               {
                    return "System could not calculate remaining time. Driver missing";
               }
                 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
         }        //Source:oiughdfjh
         return powerDisconnected;

     }


}
 
}
     
    
   


