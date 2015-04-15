using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbWrite : DbConnect
    {
        public DbWrite() 
        {

        }

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
    }
}
