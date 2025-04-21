using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WeatherApp
{
    public class DatabaseHelper
    {
        private static string dbPath = Path.Combine(Application.StartupPath, "Database", "userdata.db");
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Users (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Username TEXT NOT NULL UNIQUE,
                                            Password TEXT NOT NULL);";
                SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @user AND Password = @pass";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
        }
    }
}
