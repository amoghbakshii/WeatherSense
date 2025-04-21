using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WeatherApp
{
    public class MySQLHelper
    {
        private static string connectionString = "server=localhost;user=root;password=1523;database=weatherapp_db;";

       
        public static void InsertUserHistory(string username, string city, string temperature, string condition)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO user_history (username, city, temperature, condition_text, date_time) " +
                               "VALUES (@username, @city, @temp, @cond, NOW())";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@temp", temperature);
                cmd.Parameters.AddWithValue("@cond", condition);
                cmd.ExecuteNonQuery();
            }
        }

        
        public static DataTable GetUserHistory(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT city, temperature, condition_text, date_time FROM user_history " +
                               "WHERE username = @username ORDER BY date_time DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
