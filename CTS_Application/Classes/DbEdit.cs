using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbEdit : DbConnect
    {
        public DbEdit()
        {

        }
       /// <summary>
       /// Metoden ChangeSetPoint skal primært sett oppdatere cellene for setpunktene i tabellen "settings" i databasen.
       /// Ved første oppstart av systemet vil derimot denne raden mangle, og dermed må denne raden generes. (INSERT INTO)
       /// For å unngå DUPLICATE error brukes spørringen i variables "query".
       /// Hvis det finnes en rad med samme ID endres bare settpunktene.
       /// </summary>
       /// <param name="settingID">Brukt for å verifisere rad 1. Lagt til som et parameter i metoden i tilfelle det ønskes flere predefinerte innstillinger.  </param>
       /// <param name="setPointLowIn">Det nedre settpunktet for temperatur.</param>
       /// <param name="setPointHighIn">Det øvre settpunktet for temperatur.</param>
        public void ChangeSetPoint(int settingID, double setPointLowIn, double setPointHighIn)
        {
            try
            {
                //Souce:
                //http://stackoverflow.com/questions/15383852/sql-if-exists-update-else-insert-into
                string query = "INSERT INTO settings(settings_ID, setpoint_low, setpoint_high) VALUES (@settingID, @setPoint_low, @setPoint_high) ON DUPLICATE KEY UPDATE setpoint_low = VALUES(setpoint_low), setpoint_high = VALUES(setpoint_high);";
                //Sjekker at tilkoblingen er åpen.
                if (this.OpenConnection() == true)
                {
                    ///Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Henter inn verdiene fra parameterene og legger de til som en verdi i spørringen query
                        cmd.Parameters.AddWithValue("@settingID", settingID);
                        cmd.Parameters.AddWithValue("@setPoint_low", setPointLowIn);
                        cmd.Parameters.AddWithValue("@setPoint_high", setPointHighIn);
                        //Kjører en SQL-commando uten å få noen verdi tilbake.
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert into settings" + ex.Message);
            }
        }
        /// <summary>
        /// Metoden brukes til å fjerne alle radene i en tabell.
        /// </summary>
        /// <param name="tablename">Navnet på tabellen som ønskes å slettes.</param>
        public void DeleteRecordsInTable(string tablename)
        {
            try
            {
                string query = "TRUNCATE TABLE " + tablename;
                //Sjekker at tilkoblingen er åpen.
                if (this.OpenConnection() == true)
                {
                    //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        //Kjører en SQL-commando uten å få noen verdi tilbake.
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\r\n");
            }
        }
       /// <summary>
       /// Metoden EditComPort skal primært sett oppdatere verdien til COM_port i tabellen "settings" i databasen.
       /// Ved første oppstart av systemet vil derimot raden hvor cellen er mangle, og dermed må denne raden generes. (INSERT INTO)
       /// For å unngå DUPLICATE error brukes spørringen i variables "query".
       /// Hvis det finnes en rad med samme ID endres bare settpunktene.
       /// </summary>
        /// <param name="settingID">Brukt for å verifisere rad 1. Lagt til som et parameter i metoden i tilfelle det ønskes flere predefinerte innstillinger.</param>
       /// <param name="comPortIn">Verdien til comporten. "COM3" for eksempel.</param>
        public void EditComPort(int settingID, string comPortIn)
        {
            try
            {
                string query = "INSERT INTO settings(settings_ID, COM_port) VALUES (@settingID, @comPort) ON DUPLICATE KEY UPDATE COM_port = VALUES(COM_port);";
                //Sjekker at tilkoblingen er åpen.
                if (this.OpenConnection() == true)
                {
                    //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Henter inn verdiene fra parameterene og legger de til som en verdi i spørringen query
                        cmd.Parameters.AddWithValue("@settingID", settingID);
                        cmd.Parameters.AddWithValue("@comPort", comPortIn);
                        ///Kjører en SQL-commando uten å få noen verdi tilbake.
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert into settings com" + ex.Message);
            }
        }
       
    }
}
