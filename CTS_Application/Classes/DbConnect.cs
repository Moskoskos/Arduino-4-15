using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data;


namespace CTS_Application
{
    public partial class DbConnect
    {

        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Source:
        /// http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
        /// DbConnect-klassen tar kun seg av login-informasjon, åpning og lukking av tilkoblinger. Dette er baseklassen for DbRead, DbWrite, dbEdit.
        /// </summary>
        public DbConnect()
        {
            server = "127.0.0.1"; //IP-addressen til databasen. 
            database = "cts"; // Navnet til databasen som skal kobles til.
            uid = "root"; //Brukernavnet for å få logget seg på databasen,
            password = ""; //Passordet som blir brukt i samsvar med brukernavnet.
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        /// <summary>
        /// Åpner en tilkobling mot databasen ved å benytte informasjonen i konstructoren. Sjekker først om tilkoblingen er åpen, forså å stenge og åpne den igjen.
        /// </summary>
        /// <returns>Returnerer BOOL</returns>
        public bool OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Close();
                    connection.Open();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public bool CloseConnection()
        {

            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
    }
}
