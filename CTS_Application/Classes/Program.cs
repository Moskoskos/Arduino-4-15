using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CTS_Application
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// Lag til en sjekk som skal sørge for at databasen kjører og at det er innstillinger i tabellen settings.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        //Source:oiughdfjh
            DbRead dbRead = new DbRead();
            DbEdit dbEdit = new DbEdit();
            //For å unngå en drøss med feilmeldinger i starten at programmet ikke finner setpunkter eller Comport så kjører den en sjekk i starten.
            Process[] instance = Process.GetProcessesByName("mysqld");
            //Sjekker om databasen er tilgjengelig.
            if (instance.Length != 0)
            {
                //Hvis databasen er tilgjengelig, sjekker den om det finnes en rad for settings. Hvis det ikke gjør det, putter den inn default verdier.
                if (dbRead.CheckIfTableIsEmpty() == "0" )
                {
                    dbEdit.ChangeSetPoint(1, -20, 30);
                    dbEdit.EditComPort(1, "3");
                    Application.Run(new frmMain());
                }
                else
                {
                    Application.Run(new frmMain());
                }
                
            }
                //Hvis databasen ikke er tilgjengelig sier programmet i fra til brukerern.
            else if (instance.Length == 0)
            {
                MessageBox.Show("The MySQL server is not running! Start it in order to run the CTS software.");
                
            }
            
            
            
        }
   }
}
