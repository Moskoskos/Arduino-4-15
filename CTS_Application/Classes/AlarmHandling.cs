using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Application
{
    class AlarmHandling//klasse for temperaturalarmer
    {
        public string description;
        public int tagId;
        public bool type;//true = lav alarm, false = høy alarm
        //private instansvariabler brukt i raiseAlarm metode
        private bool alarm = false;
        private bool currentAlarm = false;

        public AlarmHandling(string initDescription, int initTagId, bool initType)
        {
            description = initDescription;
            tagId = initTagId;
            type = initType;
        }
        public AlarmHandling()
        {       }
        public bool RaiseAlarm(double sp, double pv) // returnerer true, hvis alarm. Temperatur må gå tilbake til "normal" før man får ny alarm.
        {
            //bool lastCheck = false;
            if (type==true)//lav alarm
            {
                if ((pv < sp) && (currentAlarm == false))//pv lavere enn sp og ikke alarmstatus = ny alarm
                {
                    alarm = true;
                    currentAlarm = true;
                }
                else if ((currentAlarm == true) && (pv > sp))//pv går over sp igjen etter alarmstatus = vi kan få ny alarm
                {
                    currentAlarm = false;
                    //alarm = false;
                }
                else
                { 
                    alarm = false; 
                }
            }
            else//høy alarm
            {
                if ((pv > sp) && (currentAlarm == false))//pv høyere enn sp og ikke alarmstatus = ny alarm
                {
                    alarm = true;
                    currentAlarm = true;
                }
                else if ((currentAlarm == true) && (pv < sp))//pv går under sp igjen etter alarmstatus = vi kan få ny alarm
                {
                    currentAlarm = false;
                }
                else
                {
                    alarm = false;
                }
            }
            return alarm;
        }
     }
    
}
