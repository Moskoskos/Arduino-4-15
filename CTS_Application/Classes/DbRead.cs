using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbRead : DbConnect
    {
        public DbRead()
        {
            
        }
        DbEdit dbEdit = new DbEdit();
        /// <summary>
        /// Metoden GetLoWSP kjører en spørring for å hente setpoint_low fra databasen, hvor settings_id er like id.
        /// </summary>
        /// <param name="id">id tilsvarer raden i tabellen settings.</param>
        /// <returns>Returnerer verdien for settpunktet.</returns>
         public string GetLowSP(int id)
        {
                string result = "";
                string query = "SELECT setpoint_low FROM settings WHERE settings_id = @id";
                try
                {
                    //Sjekker at tilkoblingen er åpen.
                    if (this.OpenConnection() == true)
                    {
                        //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            //Kjører spørringen og får en verdi tilbake.
                            result = cmd.ExecuteScalar().ToString();
                            CloseConnection();
                        }
                    }
                }
                catch (Exception)
                {
                    //Hvis tabellen for instillinger er tom vil dbEdit bli kalt for å gi den verdier.
                    dbEdit.ChangeSetPoint(1, -20, 20);
                    dbEdit.EditComPort(1, "COM3");
                } 
                return result;
        }
        /// <summary>
        /// Metoden GetHighSp kjører en spørring for å hente ut setpoint_high fra tabellen settings.
        /// </summary>
        /// <param name="id">id tilsvarer raden i tabellen settings.</param>
        /// <returns></returns>
        public string GetHighSp(int id)
        {
            string result = "";
            string query = "SELECT setpoint_high FROM settings WHERE settings_id = @id";
            //Sjekker at tilkoblingen er åpen.
            if (this.OpenConnection() == true)
            {
                //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    //Kjører spørringen og får en verdi tilbake.
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }
       /// <summary>
       /// Metoden GetTotalRow kjører en spørring for å hente informasjon om antall rader i users.
       /// </summary>
       /// <returns>Returnerer antall rader.</returns>
        public string GetTotalRow()
        {
            string result = "";
            string query = "SELECT COUNT(*) FROM users";
            //Sjekker at tilkoblingen er åpen.
            if (this.OpenConnection() == true)
            {
                //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    //Kjører spørringen og får en verdi tilbake.
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }
        /// <summary>
        /// Denne metoden kjører en spørring mot tabellen users i databasen hvor den skal hente ut 1 email addresse.
        /// Metoden velger email utifra hvilken ID raden har. Denne er koblet mot metoden GetTotalRow for å itterere igjennom alle radene.
        /// </summary>
        /// <param name="idIn">tilsvarende userID i tabelelen users. </param>
        /// <returns>Returnerer en email-addresse.</returns>
        public string GetEmail(int idIn)
        {
            string result = "";
            string query = "SELECT email FROM users WHERE userID = @id";
            //Sjekker at tilkoblingen er åpen.
            if (this.OpenConnection() == true)
            {
                //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                using(MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@id",idIn );
                    //Kjører spørringen og får en verdi tilbake.
                        result = cmd.ExecuteScalar().ToString();
                        CloseConnection();
                }
            }
              return result;  
        }
        /// <summary>
        /// Metoden GetComPort kjører en spørring mot tabellen settings og henter ComPort-verdien definert utifra idin.
        /// </summary>
        /// <param name="idIn">id tilsvarer raden i tabellen settings.</param>
        /// <returns>Returnerer comport verdien. Feks: "COM3"</returns>
        public string GetComPort(int idIn)
        {
            string result = "";
            string query = "SELECT COM_port FROM settings WHERE settings_id = @id";
            //Sjekker at tilkoblingen er åpen.
            if (this.OpenConnection() == true)
            {
                //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idIn);
                    //Kjører spørringen og får en verdi tilbake.
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }
        public double GetLatestValue()
        {
            string result = "";
            string query = "SELECT value FROM historian LIMIT 1;";
            if (this.OpenConnection() == true)
            {
                using(MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return Convert.ToDouble(result);
        }
        public string CheckIfTableIsEmpty()
        {
            string result = "";
            string query = "Select COUNT(*) FROM settings;" ;
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }

    }
  }

