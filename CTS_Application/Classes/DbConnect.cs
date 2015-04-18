using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using System.Management;
//using Microsoft.Win32;
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
        /// 
        /// </summary>
        /// <returns></returns>
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
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Could not connect to database");
                        break;
                    case 1045:
                        MessageBox.Show("Wrong password / username");
                        break;
                }
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        