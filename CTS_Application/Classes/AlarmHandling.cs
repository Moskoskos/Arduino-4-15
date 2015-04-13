using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//test
namespace CTS_Application
{
    class AlarmHandling//klasse for temperaturalarmer
    {
        public string description;
        public int tagId;
        //private instansvariabler brukt i raiseAlarm metode
        private bool lowAlarm = false;
        private bool highAlarm = false;
        private bool currentLowAlarm = false;
        private bool currentHighAlarm = false;
        private bool outOfRangeAlarm = false;
        private bool batteryAlarm = false;
        private bool comAlarm = false;

        public AlarmHandling(string initDescription, int initTagId)
        {
            description = initDescription;
            tagId = initTagId;
        }
        public AlarmHandling()
        {       }
        public bool LowTempAlarm(double sp, double pv) // returnerer true, hvis alarm. Temperatur må gå tilbake til "normal" før man får ny alarm.
        {            
                if ((pv < sp) && (currentLowAlarm == false))//pv lavere enn sp og ikke alarmstatus = ny alarm
                {
                    lowAlarm = true;
                    currentLowAlarm = true;
                }
                else if ((currentLowAlarm == true) && (pv > sp))//pv går over sp igjen etter alarmstatus = vi kan få ny alarm
                {
                    currentLowAlarm = false;
                }
                else
                { 
                    lowAlarm = false; 
                }
            
            return lowAlarm;
        }
            public bool HighTempAlarm(double sp, double pv)//høy alarm
            {
                if ((pv > sp) && (currentHighAlarm == false))//pv høyere enn sp og ikke alarmstatus = ny alarm
                {
                    highAlarm = true;
                    currentHighAlarm = true;
                }
                else if ((currentHighAlarm == true) && (pv < sp))//pv går under sp igjen etter alarmstatus = vi kan få ny alarm
                {
                    currentHighAlarm = false;
                }
                else
                {
                    highAlarm = false;
                }
                return highAlarm;
             }
        //gir alarm hvis temperaturverdi er utenfor gitte verdier
            public bool TempOutOfRange(double pv)
            {
                if (pv < -100)
                {
                    outOfRangeAlarm = true;
                }
                else if (pv > 100)
                {
                    outOfRangeAlarm = true;
                }
                else
                {
                    outOfRangeAlarm = false;
                }
                return outOfRangeAlarm;
            }
        //gir alarm hvis nettspenning forsvinner
            public bool BatteryAlarm(bool powerstatus)
            {
                if (powerstatus == true)
                {
                    batteryAlarm = true;
                }
                else if (powerstatus == false)
                {
                    batteryAlarm = false;
                }
                return batteryAlarm;
            }
        //gir alarm hvis com feil
            public bool ArduComAlarm(bool comStatus)
            {
                if (comStatus == true)
                {
                    comAlarm = true;
                }
                else if (comStatus == false)
                {
                    comAlarm = false;
                }
                return comAlarm;
            }
        //Lag en metode som skriver feilmeldingen og verdi til database. Jeg lager databasespørringen for deg. <3 :*
     }
    
}
