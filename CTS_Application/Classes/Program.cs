using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS_Application
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        //Source:oiughdfjh
            DbRead dbRead = new DbRead();
            DbEdit dbEdit = new DbEdit();
            if (dbRead.CheckIfTableIsEmpty() == "0" )
            {
                dbEdit.ChangeSetPoint(1, -20, 20);
                dbEdit.EditComPort(1, "3");
                Application.Run(new frmMain());
            }
            
            else
            {
                Application.Run(new frmMain());
            }
            
        }
   }
}
