using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbEdit : DbConnect
    {
        public DbEdit()
        {

        }
        public bool ChangeSetPoint(int settingID, double setPointLowIn, double setPointHighIn)
        {
            try
            {
                string query = "INSERT INTO settings(settings_ID, setpoint_low, setpoint_high) VALUES (@settingID, @setPoint_low, @setPoint_high) ON DUPLICATE KEY UPDATE setpoint_low = VALUES(setpoint_low), setpoint_high = VALUES(setpoint_high);";
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
                        // Execute the query
                        cmd.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert into settings" + ex.Message);
            }
            return false;
        }
        public bool DeleteRecordsInTable(string tablename)
        {
            try
            {
                string query = "TRUNCATE TABLE " + tablename;
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                        CloseConnection();
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
