using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
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

        //Source:
        //http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
        //The server settings for logging on to the MySql Database
        public DbConnect()
        {
            server = "127.0.0.1";
            database = "cts";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
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
        //Close connection
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
        