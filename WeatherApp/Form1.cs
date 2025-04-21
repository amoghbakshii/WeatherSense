using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.Data;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private const string apiKey = "b92cf99a707e48f384550030251004"; 

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Bro, enter a city name 😭");
                return;
            }

            await GetWeatherData(city);
        }

        private void InitializeDatabase()
        {
            string dbPath = "Data Source=weatherlog.db;Version=3;";
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS WeatherLog (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        City TEXT,
                                        Temperature REAL,
                                        Condition TEXT,
                                        DateSearched DATETIME
                                    );";
                using (var cmd = new SQLiteCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private async Task GetWeatherData(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}&aqi=no";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic weatherData = JsonConvert.DeserializeObject(json);

                        lblCity.Text = $"City: {weatherData.location.name}, {weatherData.location.country}";


                       

                     
                        labelTemp.Text = $"Temperature: {weatherData.current.temp_c} °C";

                        lblHumidity.Text = $"Humidity: {weatherData.current.humidity}%";
                        lblWindSpeed.Text = $"Wind: {weatherData.current.wind_kph} km/h";
                        lblUV.Text = $"UV Index: {weatherData.current.uv}";
                        lblLocalTime.Text = $"Local Time: {weatherData.location.localtime}";
                        lblVisibility.Text = $"Visibility: {weatherData.current.vis_km} km";
                        lblCloud.Text = $"Cloud: {weatherData.current.cloud}%";
                        SaveWeatherToHistory(city, (double)weatherData.current.temp_c, (string)weatherData.current.condition.text);
                       
                        MySQLHelper.InsertUserHistory("guest_user", city,
                            $"{weatherData.current.temp_c} °C",
                            $"{weatherData.current.condition.text}");


                    }
                    else
                    {
                        MessageBox.Show("City not found or weather data unavailable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SaveWeatherToHistory(string city, double temp, string condition)
        {
            string dbPath = "Data Source=weatherlog.db;Version=3;";
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                string insertQuery = "INSERT INTO WeatherLog (City, Temperature, Condition, DateSearched) VALUES (@city, @temp, @condition, @date)";
                using (var cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@temp", temp);
                    cmd.Parameters.AddWithValue("@condition", condition);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
            DatabaseHelper.InitializeDatabase();

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblUV_Click(object sender, EventArgs e)
        {

        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            LoadWeatherHistory();
            dataGridViewHistory.Visible = true;
        }

        private void LoadWeatherHistory()
        {
          

            string username = "guest_user";
            DataTable historyTable = MySQLHelper.GetUserHistory(username);
            dataGridViewHistory.DataSource = historyTable;
        }


    }
}
