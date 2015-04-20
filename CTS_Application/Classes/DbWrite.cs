using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    /// <summary>
    /// Klassen tar for seg alt av skriving til databasen. 
    /// Metoder:
    /// InsertIntoUsers - Skriver bruker-informasjon inn til tabellen users.
    /// WriteTempToHistorian - Skriver temperatur-verdiene til tabellen historian.
    /// WriteToAlarmHistorian - Skriver alarmer til tabellen alarm_historian.
    /// 
    /// </summary>
    class DbWrite : DbConnect
    {
        
        public DbWrite() 
        {

        }
        /// <summary>
        /// InsertIntoUsers skriver inn brukerinformasjon inn til tabellen users i databasen. Det er her abonnent-informasjon lagres.
        /// </summary>
        /// <param name="usernameIn">Ønsket brukernavn. Tilrettelagt for eksandering av webside hvor innlogging kan være nødvendig.</param>
        /// <param name="firstnameIn">Fornavnet til abonnenten.</param>
        /// <param name="lastnameIn">Etternavnet til abonnenten.</param>
        /// <param name="emailIn">Email-adressen til abonnenten.</param>
        /// <param name="numberIn">Telefonnummeret til abonnenten.</param>
        public void InsertIntoUsers(string usernameIn, string firstnameIn, string lastnameIn, string emailIn, int numberIn)
        {
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {

                    string query = "INSERT INTO users(username, firstname, lastname, email, phonenumber)VALUES(@username, @firstname, @lastname,@email,@number);";
                    //Sjekker at tilkoblingen er åpen.
                    if (base.OpenConnection() == true)
                    {
                        //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Henter inn verdiene fra parameterene og legger de til som en verdi i spørringen query
                            cmd.Parameters.AddWithValue("@username", usernameIn);
                            cmd.Parameters.AddWithValue("@firstname", firstnameIn);
                            cmd.Parameters.AddWithValue("@lastname", lastnameIn);
                            cmd.Parameters.AddWithValue("@email", emailIn);
                            cmd.Parameters.AddWithValue("@number", numberIn);
                            //Kjører en SQL-commando uten å få noen verdi tilbake.
                            cmd.ExecuteNonQuery();
                            CloseConnection();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Could not insert into users" + ex.Message);
                }
            }
        }
        /// <summary>
        /// Skriver temperaturverdier til tabellen "historian".
        /// </summary>
        /// <param name="valueIn">Temperaturverdien.</param>
        public void WriteTempToHistorian(double valueIn)
        {
            //
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {
                    string query = "INSERT INTO historian(value)VALUES(@value);";
                    //Sjekker at tilkoblingen er åpen.
                    if (this.OpenConnection() == true)
                    {
                        //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Henter inn verdien parameteren og legger den til som en verdi i spørringen query
                            cmd.Parameters.AddWithValue("@value", valueIn);
                            //Kjører en SQL-commando uten å få noen verdi tilbake.
                            cmd.ExecuteNonQuery();
                            CloseConnection();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Could not insert into historian" + ex.Message);
                }
            }
        }

        //Write to alarm table
        /// <summary>
        /// Skriver alarmer til alarm_historian.
        /// </summary>
        /// <param name="alarmCodeIn">Alarmkoden fra alam-hendelsen.</param>
        /// <param name="descriptionIn">Utdypende beskrivelse av alarmkoden.</param>
        public void WriteToAlarmHistorian(int alarmCodeIn, string descriptionIn)
        {
            if (alarmCodeIn > 0)
            {
                try
                {
                    string query = "INSERT INTO alarm_historian(alarm_id, description) VALUES(@alarmvar,@description);";
                    //Sjekker at tilkoblingen er åpen.
                    if (this.OpenConnection() == true)
                    {
                        //Bruker spørringen ovenfor og tilkoblingstrengen i DbConnect.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            /// Henter inn verdiene fra parameterene og legger de til som en verdi i spørringen query
                            cmd.Parameters.AddWithValue("@alarmvar", alarmCodeIn);
                            cmd.Parameters.AddWithValue("@description", descriptionIn);
                            //Kjører en SQL-commando uten å få noen verdi tilbake.
                            cmd.ExecuteNonQuery();
                            CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not insert into alarm_historian" + ex.Message + "\r\r\n");
                }
            }
        }
 
    }
}
