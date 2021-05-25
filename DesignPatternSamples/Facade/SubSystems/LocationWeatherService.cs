namespace Facade
{
    public class LocationWeatherService
    {
        public string GetCurrentWeather(double latitude, double altitude)
        {
            return "Current Weather ===> Sunny";
        }

        public string GetTomorrowWeather(double latitude, double altitude)
        {
            return "Tomorrow Weather ===> Cloudy";
        }
    }
}