using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace CTS_Application
{
    class AlarmHandling
    {
        
        //private instansvariabler brukt i alarm metoder
        private bool lowAlarm = false;
        private bool highAlarm = false;
        private bool currentLowAlarm = false;
        private bool currentHighAlarm = false;
        private bool outOfRangeAlarm = false;
        private bool currentOutOfRange = false;
        private bool batteryAlarm = false;
        private bool currentBatteryAlarm = false;
        private bool comAlarm = false;
        private bool currentComAlarm = false;
        private bool currentLowBatteryalarm = false;
        private bool lowBatteryAlarm = false;

        public AlarmHandling()
        {       }
        /// <summary>
        /// Lav temperaturalarm
        /// </summary>
        /// <param name="sp">Setpunkt for lav temperaturalarm</param>
        /// <param name="pv">Temperatur</param>
        /// <returns>True hvis lav temperatur alarm</returns>
        public bool LowTempAlarm(double sp, double pv)
        {            
                if ((pv < sp) && (currentLowAlarm == false))
                {
                    lowAlarm = true;
                    currentLowAlarm = true;
                }
                else if ((currentLowAlarm == true) && (pv > (sp + 1.0)))
                {
                    currentLowAlarm = false;
                }
                else
                { 
                    lowAlarm = false; 
                }
            
            return lowAlarm;
        }
        /// <summary>
        /// Høy temperaturalarm
        /// </summary>
        /// <param name="sp">Setpunkt for høy temperaturalarm</param>
        /// <param name="pv">Temperatur</param>
        /// <returns>True hvis høy temperatur alarm</returns>
            public bool HighTempAlarm(double sp, double pv)
            {
                if ((pv > sp) && (currentHighAlarm == false))
                {
                    highAlarm = true;
                    currentHighAlarm = true;
                }
                else if ((currentHighAlarm == true) && (pv < (sp - 1.0)))
                {
                    currentHighAlarm = false;
                }
                else
                {
                    highAlarm = false;
                }
                return highAlarm;
             }
        
        /// <summary>
        /// gir alarm hvis temperaturverdi er utenfor gitte verdier
        /// </summary>
        /// <param name="pv">Temperatur</param>
        /// <returns>True hvis temperatur out of range</returns>
            public bool TempOutOfRange(double pv)
            {
                if (((pv < -100) || (pv > 100)) && (currentOutOfRange == false))
                {
                    outOfRangeAlarm = true;
                    currentOutOfRange = true;
                }
                else if ((currentOutOfRange == true) && ((pv > -100) && (pv < 100)))
                {
                    currentOutOfRange = false;
                }
                else
                {
                    outOfRangeAlarm = false;
                }
                return outOfRangeAlarm;
            }
        /// <summary>
        /// Gir alarm hvis nettspenning forsvinner
        /// </summary>
        /// <param name="powerstatus">Status på strømtilførsel fra Battery monitoring klasse</param>
        /// <returns>True hvis strømtilførsel blir frakoblet</returns>
            public bool BatteryAlarm(bool powerstatus)
            {
                if ((powerstatus == true) && (currentBatteryAlarm == false))
                {
                    batteryAlarm = true;
                    currentBatteryAlarm = true;
                }
                else if ((powerstatus == false) && (currentBatteryAlarm == true))
                {
                    currentBatteryAlarm = false;
                }
                else
                {
                    batteryAlarm = false;
                }
                return batteryAlarm;
            }
        /// <summary>
        /// Gir alarm hvis com feil
        /// </summary>
        /// <param name="comStatus">Status på tilkobling mellom Arduino og COM port fra ArduinoCom klasse</param>
        /// <returns>True hvis Arduino blir frakoblet</returns>
            public bool ArduComAlarm(bool comStatus)
            {
                if ((comStatus == true) && (currentComAlarm == false))
                {
                    comAlarm = true;
                    currentComAlarm = true;
                }
                else if ((comStatus == false) && (currentComAlarm == true))
                {
                    currentComAlarm = false;
                }
                else
                {
                    comAlarm = false;
                }
                return comAlarm;
            }
            /// <summary>
            /// Gir alarm hvis batteriprosent går under alarmgrense
            /// </summary>
            /// <param name="sp">settpunkt for alarmgrense</param>
            /// <param name="percent">batteriprosent</param>
            /// <returns>true hvis batteriprosent går under alarmgrense</returns>
            public bool LowBatteryPercent(int sp, int percent, bool chargingStatus)
            {
                if ((percent < sp) && (currentLowBatteryalarm == false) && (chargingStatus == true) )
                {
                    lowBatteryAlarm = true;
                    currentLowBatteryalarm = true;
                }
                else if ((currentLowBatteryalarm == true) && (percent > (sp + 1.0)))
                {
                    currentLowBatteryalarm = false;
                }
                else
                {
                    lowBatteryAlarm = false;
                }

                return lowBatteryAlarm;
            }
     }
    
}
