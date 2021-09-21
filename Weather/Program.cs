using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Hello!  Welcome to what's my Weather App");

            string cityName;
            do
            {
                Console.WriteLine("Please enter the name of the city you would like to get the current weather conditions:  ");

                cityName = Console.ReadLine().ToUpper();

                if (cityName == "END")
                {
                    break;
                }
                GetWeather.Weather(cityName);

            } while (cityName != "END");
                

            

    

            
            
        }
    }
}
