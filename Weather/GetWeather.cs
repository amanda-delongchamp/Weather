using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Weather
{
    class GetWeather
    {
        public static void Weather(string cityName)
        {

            var client = new HttpClient();
            
            string apiKey = "0f0b2208a39c49475a0497c2d52e9e38";
            
            string openWeatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={apiKey}";

            string openWeatherResponse = client.GetStringAsync(openWeatherURL).Result;

            string temps = JObject.Parse(openWeatherResponse).GetValue("main").ToString();

            string condition = JObject.Parse(openWeatherResponse).GetValue("weather").ToString();

            Console.WriteLine($"Today's Weather for {cityName}...");
            Console.WriteLine($"Temps:  {temps}");
            Console.WriteLine($"Condition:  {condition}");
        }
        
    }
}
