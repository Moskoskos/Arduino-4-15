using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Application.Classes
{
    class AlarmHandling
    {
        public string description;
        public double pv;//temperatur
        public double sp;//alarmsetpunkt
        public int tagId;
        public bool type;//true = lav alarm, false = høy alarm
        public int hysterese;

        public AlarmHandling(string initDescription, double initPv, double initSp, int initTagId, bool initType, int initHystirese)
        {
            description = initDescription;
            pv = initPv;
            sp = initSp;
            tagId = initTagId;
            type = initType;
            hysterese = initHystirese;
        }
        public AlarmHandling()
        {

        }
        public bool RaiseAlarm() // returnerer true, hvis alarm
        {
            bool alarm = false;
            bool lastCheck;
            if (type==true)//lav alarm
            {
                if (((pv + hysterese) < sp) && (lastCheck = false))
                {
                    alarm = true;
                }
            }
            else//høy alarm
            {
                if (((pv + hysterese) > sp) && (lastCheck = false))
                {
                    alarm = true;
                }
            }
            lastCheck = alarm;// lagrer forrige alarmstatus for bruk til neste sjekk
            return alarm;
        }
     }
    
}
