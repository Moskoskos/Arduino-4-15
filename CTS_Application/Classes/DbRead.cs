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
            //Jau
        }
        DbEdit dbEdit = new DbEdit();
        /// <summary>
        /// Metoden GetLoWSP kjører en spørring for å hente setpoint_low fra databasen, hvor settings_id er like id.
        /// </summary>
        /// <param name="id">id tilsvarer raden i settings tabellen.</param>
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
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idIn"></param>
        /// <returns></returns>
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
                        result = cmd.ExecuteScalar().ToString();
                        CloseConnection();
                }
            }
              return result;  
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idIn"></param>
        /// <returns></returns>
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
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }

    }
  }

