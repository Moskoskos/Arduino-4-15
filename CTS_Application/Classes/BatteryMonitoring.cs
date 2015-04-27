using System;
using System.Windows.Forms;

//Source:
//https://myashkap.wordpress.com/2011/03/08/c-sharp-how-to-make-your-own-battery-monitor/
//

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
        /// <summary>
        /// 
        /// </summary>
        public int PercentBatteryLeft
        {
            get
            {
               powerPercent = Convert.ToInt32(power.BatteryLifePercent *100);
               return powerPercent;
            }
        }
        /// <summary>
        /// Egenskap som henter status om systemet  / PCn er koblet til 230V. 
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
        /// Henter estimert tid før PCn er tom for strøm.
        /// </summary>
        public double TimeLeft
        {
             get
            {
               timeLeft = power.BatteryLifeRemaining / 60 ;
                 return timeLeft;
            }
        }
        /// <summary>
        /// En metode for å sjekke om systemet er koblet til 230V.
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
         }
         return powerDisconnected;

     } 
}
 
}
     
    
   


