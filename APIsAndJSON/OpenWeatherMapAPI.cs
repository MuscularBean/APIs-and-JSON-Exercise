using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private HttpClient _client;

        public OpenWeatherMapAPI (HttpClient client)
        {
            _client = client;
        }

        public string Forecast()
        {
            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?lat=33.42&lon=-111.83&appid=1db1a2d0cf4ce3d4877ea9fb3b3a19da&units=imperial";


            var weatherResponse = _client.GetStringAsync(weatherURL).Result;

            var weatherFormat = JObject.Parse(weatherResponse).GetValue("main").ToString();

            var currentWeather = JObject.Parse(weatherFormat).GetValue("temp");

            return currentWeather.ToString();
        }
    }
}
