using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var forecaster = new CityWeatherForecaster();
            var currentWeather = forecaster.GetCurrentWeather("My City");
            Console.WriteLine(currentWeather);

            var tomorrowWeather = forecaster.GetTomorrowWeather("Your City");
            Console.WriteLine(tomorrowWeather);

            Console.ReadKey();
        }
    }
}
