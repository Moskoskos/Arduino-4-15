using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTS_Application
{
    class DbRead : DbConnect
    {
        public DbRead()
        {

        }
         public string GetLowSP(int id)
        {
                string result = "";
                string query = "SELECT setpoint_low FROM settings WHERE settings_id = @id";
                if (this.OpenConnection() == true)
	                {
		               using (MySqlCommand cmd = new MySqlCommand(query, connection))
                           {
                               cmd.Parameters.AddWithValue("@id", id);
                              result = cmd.ExecuteScalar().ToString();
                              CloseConnection();
                           }
	                }
                return result;
        }
        public string GetHighSp(int id)
        {
            string result = "";
            string query = "SELECT setpoint_high FROM settings WHERE settings_id = @id";
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }
       
        public string GetTotalRow()
        {
            string result = "";
            string query = "SELECT COUNT(*) FROM users";
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    result = cmd.ExecuteScalar().ToString();
                    CloseConnection();
                }
            }
            return result;
        }

        public string GetEmail(int idIn)
        {
            string result = "";
            string query = "SELECT email FROM users WHERE userID = @id";
            if (this.OpenConnection() == true)
            {
                using(MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@id",idIn );
                        result = cmd.ExecuteScalar().ToString();
                        CloseConnection();
                }
            }
              return result;  
        }

        public string GetComPort(int idIn)
        {
            string result = "";
            string query = "SELECT COM_port FROM settings WHERE settings_id = @id";
            if (this.OpenConnection() == true)
            {
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

