﻿using System;
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
     
        //Writes temperature values to database
        public bool WriteTempemperatureToHistorian(double valueIn)
        {
            //
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {
                    string query = "INSERT INTO historian(value)VALUES(@value);";
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
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + "\r\r\n" + ex.GetType());
                    return false;
                }
            }
        }
            //Source:
            //http://stackoverflow.com/questions/19196824/how-to-get-number-of-rows-in-a-table-in-mysql
            //

        public bool WriteToAlarmHistorian(int alarmCodeIn, string descriptionIn)
        {
            if (alarmCodeIn > 0)
	            {
                    try
                        {
                            
                            string query = "INSERT INTO alarm_historian(alarm_id, description) VALUES(@alarmvar,@description);";
                            if (this.OpenConnection() == true)
                            {


                                using (MySqlCommand cmdRegisterAlarm = new MySqlCommand(query, connection))
                                {
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
        } //Done?
        //Use this if settings should be stored in DB for use in webpage
        public bool ChangeSetPoint(int settingID, double setPointLowIn, double setPointHighIn, double hysteresisIn)
        {
            try
            {
                string query = "UPDATE settings SET setpoint_low = @setPoint_low, setpoint_high = @setPoint_high, hysteresis = @hysteresis WHERE settings_id = @settingID;";
                //Checks if connection is open
                if (this.OpenConnection() == true)
                {
                    //uses the connection string and the query created above.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // The paramteres mentioned in VALUES is here given a value
                        cmd.Parameters.AddWithValue("@settingID", settingID);
                        cmd.Parameters.AddWithValue("@setPoint_low", setPointLowIn);
                        cmd.Parameters.AddWithValue("@setPoint_high", setPointHighIn);
                        cmd.Parameters.AddWithValue("@hysteresis", hysteresisIn);
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
        public bool DeleteRecordsInTable(string tablename)
        {
                try
                {
                    //ALTER TABLE @tablename AUTO_INCREMENT=0

                    string query = "TRUNCATE TABLE " + tablename;
                    if (this.OpenConnection() == true)
                    {
                        using (MySqlCommand cmdDeleteRecords = new MySqlCommand(query, connection))
                        {
                            cmdDeleteRecords.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\r\n");
                }
            return false;
        }

        //All below needs future testing.
        //ExecuteScalar retrieves only a single value
        public string GetHistorianXCoordinate()
        {
            string temp = "";
            try
            {

                string query = "SELECT datetime_recorded FROM historian ORDER BY id DESC LIMIT 1;";
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmdGetXCoordinate = new MySqlCommand(query, connection))
                    {
                        temp = (string)cmdGetXCoordinate.ExecuteScalar();
                        temp = Convert.ToString(temp);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\r\n");
            }
            return temp;
        }
        public bool GetHistorianYCoordinate()
        {
            try
            {

                string query = "SELECT value FROM historian ORDER BY id DESC LIMIT 1;";
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmdGetYCoordinate = new MySqlCommand(query, connection))
                    {
                        cmdGetYCoordinate.ExecuteScalar();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\r\n");
            }
            return false;
        } 
            
        
    }
}
