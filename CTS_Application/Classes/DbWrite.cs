using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbWrite : DbConnect
    {
        
        public DbWrite() 
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usernameIn"></param>
        /// <param name="firstnameIn"></param>
        /// <param name="lastnameIn"></param>
        /// <param name="emailIn"></param>
        /// <param name="numberIn"></param>
        /// <returns></returns>
        public bool InsertIntoUsers(string usernameIn, string firstnameIn, string lastnameIn, string emailIn, int numberIn)
        {
            //Source:
            //http://stackoverflow.com/questions/19527554/inserting-values-into-mysql-database-from-c-sharp-application-text-box
            {
                try
                {

                    string query = "INSERT INTO users(username, firstname, lastname, email, phonenumber)VALUES(@username, @firstname, @lastname,@email,@number);";
                    //Checks if connection is open
                    if (base.OpenConnection() == true)
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
                            CloseConnection();
                        }
                    }

                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Could not insert into users" + ex.Message);
                    return false;
                }
            }
        }
                 //Writes temperature values to database
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueIn"></param>
        /// <returns></returns>
        public bool WriteTempToHistorian(double valueIn)
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
                            CloseConnection();
                        }
                    }
                    return true;
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Could not insert into historian" + ex.Message);
                    return false;
                }
            }

        }

        //Write to alarm table
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alarmCodeIn"></param>
        /// <param name="descriptionIn"></param>
        /// <returns></returns>
        public bool WriteToAlarmHistorian(int alarmCodeIn, string descriptionIn)
        {
            if (alarmCodeIn > 0)
            {
                try
                {
                    string query = "INSERT INTO alarm_historian(alarm_id, description) VALUES(@alarmvar,@description);";
                    if (this.OpenConnection() == true)
                    {


                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@alarmvar", alarmCodeIn);
                            cmd.Parameters.AddWithValue("@description", descriptionIn);
                            cmd.ExecuteNonQuery();
                            CloseConnection();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not insert into alarm_historian" + ex.Message + "\r\r\n");
                }
            }
            return false;
        }
 
    }
}
