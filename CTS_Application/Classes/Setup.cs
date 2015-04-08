using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Application.Classes
{
    class Setup
    {

        public string description;
        public double pv;
        public double sp;
        public int tagId;
        public bool type;
        public int hystirese;

        public Setup(string initDescription, double initPv, double initSp, int initTagId, bool initType, int initHystirese)
        {
            description = initDescription;
            pv = initPv;
            sp = initSp;
            tagId = initTagId;
            type = initType;
            hystirese = initHystirese;
        }

        public Setup()
        {

        }
    }
}
