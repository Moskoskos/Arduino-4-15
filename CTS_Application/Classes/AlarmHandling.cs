using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTS_Application
{
    class AlarmHandling
    {
        
        //private instansvariabler brukt i raiseAlarm metode
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


        public AlarmHandling()
        {       }
        /// <summary>
        /// returnerer true hvis temperatur er under setpunkt
        /// </summary>
        /// <param name="sp">Setpunkt for lav temperaturalarm</param>
        /// <param name="pv">Temperatur</param>
        /// <returns>lav temperatur alarm</returns>
        public bool LowTempAlarm(double sp, double pv)
        {            
                if ((pv < sp) && (currentLowAlarm == false))
                {
                    lowAlarm = true;
                    currentLowAlarm = true;
                }
                else if ((currentLowAlarm == true) && (pv > sp))
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
        /// returnerer true hvis temperatur er over setpunkt
        /// </summary>
        /// <param name="sp">Setpunkt for høy temperaturalarm</param>
        /// <param name="pv">Temperatur</param>
        /// <returns>høy temperatur alarm</returns>
            public bool HighTempAlarm(double sp, double pv)
            {
                if ((pv > sp) && (currentHighAlarm == false))
                {
                    highAlarm = true;
                    currentHighAlarm = true;
                }
                else if ((currentHighAlarm == true) && (pv < sp))
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
        /// <returns>Temperatur out of range alarm</returns>
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
        /// <returns>Alarm hvis Strømtilførsel blir frakoblet</returns>
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
        /// gir alarm hvis com feil
        /// </summary>
        /// <param name="comStatus">Status på tilkobling mellom Arduino og COM port fra ArduinoCom klasse</param>
        /// <returns>Alarm hvis Arduino blir frakoblet</returns>
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
     }
    
}
