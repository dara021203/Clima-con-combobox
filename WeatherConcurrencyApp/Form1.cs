using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        string APIKey = "3b1e07da90d4fc52eeadc2a8588ef6dc";
        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Task.Run(Request).Wait();
            //    if (openWeather == null)
            //    {
            //        throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
            //    }

            //    WeatherPanel weatherPanel = new WeatherPanel();
            //    flpContent.Controls.Add(weatherPanel);
            //}
            //catch (Exception)
            //{

            //}
            Buscar();

        }
        public double temp(double temperatura)
        {
            double temp = temperatura - 273.15;
            return temp;
        }
        public async Task Request()
        {
            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync("Managua");
        }
        DateTime convertdatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
        void Buscar()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", comboBox1.SelectedItem, APIKey);

                var json = web.DownloadString(url);
                OpenWeather info = JsonConvert.DeserializeObject<OpenWeather>(json);

                lbpuestadelsol.Text = convertdatetime(info.Sys.Sunset).ToShortTimeString();
                lbamanecer.Text = convertdatetime(info.Sys.Sunrise).ToShortTimeString();
                lbviento.Text = (info.Wind.Speed * 3.6).ToString();
                lbpresion.Text = info.Main.Pressure.ToString();
                double temperatura = Convert.ToDouble(info.Main.Temp.ToString());

                double temperaturamin = Convert.ToDouble(info.Main.Temp_min.ToString());

                double temperaturamax = Convert.ToDouble(info.Main.Temp_max.ToString());

                lbtemperatura.Text = Convert.ToString(temp(temperatura));
                lbtempmin.Text = Convert.ToString(temp(temperaturamin));
                lbtempmax.Text = Convert.ToString(temp(temperaturamax));
                lbhumidity.Text = info.Main.Humidity.ToString();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
       
            using (StreamReader archivo = File.OpenText(@"C:/Users/Admin/Desktop/city.list.json"))

            {
                // Leemos los datos del archivo desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el archivo 
                dynamic miarray = JsonConvert.DeserializeObject(json);

                // Recorremos el array de datos del JSON 
                foreach (var item in miarray)
                {
                    // Agregamos el campo nombre del archivo  al ComboBox 
                    comboBox1.Items.Add(item.name);

                }
            }
        }
    }
}