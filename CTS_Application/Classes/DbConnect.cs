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

        private MySqlConnection connection;
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
        //Insert statement
        public bool InsertIntoUsers(string usernameIn, string firstnameIn, string lastnameIn, string emailIn, int numberIn)
        {
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {
                    
                    string query = "INSERT INTO users(username, firstname, lastname, email, phonenumber)VALUES(@username, @firstname, @lastname,@email,@number);";
                    //Checks if connection is open
                    if (this.OpenConnection() == true)
                    {
                        //uses the connection string and the query created above.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // The paramteres mentioned in VALUES is here given a value
                            //stored procedures

                            cmd.Parameters.AddWithValue("@username", usernameIn);
                            cmd.Parameters.AddWithValue("@firstname", firstnameIn);
                            cmd.Parameters.AddWithValue("@lastname", lastnameIn);
                            cmd.Parameters.AddWithValue("@email", emailIn);
                            cmd.Parameters.AddWithValue("@number", numberIn);
                            // Execute the query
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        //Retrieves the number of subscribers (used in sending mail to more than one subscriber
        public int NumOfRowsSubTable()
        {
            //Datatable.Rows.count;
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users", connection))
            {
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }
        //Writes temperature values to database
        public bool WriteTempemperatureToHistorian(double valueIn)
        {
            //
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {

                    string query = "INSERT INTO historian(historian_id, datetime_recorded, value)VALUES(@id,@timestamp, @value);";
                    //Checks if connection is open
                    if (this.OpenConnection() == true)
                    {
                        //uses the connection string and the query created above.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // The paramteres mentioned in VALUES is here given a value
                            cmd.Parameters.AddWithValue("@id", NumOfRowsHistorianTable() + 1);
                            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                            cmd.Parameters.AddWithValue("@value", valueIn);
                            // Execute the query
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + "\r\r\n" + ex.GetType());
                    return false;
                }
            }
        }
        public int NumOfRowsHistorianTable()
        {
            //Source:
            //http://stackoverflow.com/questions/19196824/how-to-get-number-of-rows-in-a-table-in-mysql
            //
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM historian", connection))
            {
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }
        //Retrieve data from historian
        public int NumOfRowsAlarmHistorianTable()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM alarm_historian", connection))
            {
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }
        public bool WriteToAlarmHistorian(int alarmCodeIn, string descriptionIn)
        {
            if (alarmCodeIn > 0)
	            {
                    try
                        {
                            
                            string query = "INSERT INTO alarm_historian(alarm_event_id, datetime_recorded, alarm_id, description) VALUES(@addRow, @time, @alarmvar,@description);";
                            if (this.OpenConnection() == true)
                            {


                                using (MySqlCommand cmdRegisterAlarm = new MySqlCommand(query, connection))
                                {
                                    cmdRegisterAlarm.Parameters.AddWithValue("@addRow", NumOfRowsAlarmHistorianTable() + 1);
                                    cmdRegisterAlarm.Parameters.AddWithValue("@time", DateTime.Now);
                                    cmdRegisterAlarm.Parameters.AddWithValue("@alarmvar", alarmCodeIn);
                                    cmdRegisterAlarm.Parameters.AddWithValue("@description", descriptionIn);
                                    cmdRegisterAlarm.ExecuteNonQuery();
                                }
                            }
                            return true;
                        }
                    catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\r\r\n");
                        }
                }
           return false;
        }
        //Use this if settings should be stored in DB for use in webpage
        public bool ChangeSetPoint(double valueIn)
        {
            try
            {
                string query = "UPDATE settings(setpoint)VALUES(@value);";
                //Checks if connection is open
                if (this.OpenConnection() == true)
                {
                    //uses the connection string and the query created above.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // The paramteres mentioned in VALUES is here given a value
                        cmd.Parameters.AddWithValue("@value", valueIn);
                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                
            }
            return false;
        }
        public void TEstTestGitGit()
        {
            
        }

        public void ndTest()
        {
            return Attribute;
        }
    }
}
