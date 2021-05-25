namespace Facade
{
    public class CityWeatherForecaster
    {
        private readonly CityLocationService cityLocationService;
        private readonly LocationWeatherService locationWeatherService;

        public CityWeatherForecaster()
        {
            cityLocationService = new CityLocationService();
            locationWeatherService = new LocationWeatherService();
        }

        public string GetCurrentWeather(string cityName)
        {
            var coordinate = cityLocationService.GetLocation(cityName);
            var currentWeather = locationWeatherService.GetCurrentWeather(coordinate.Latitude, coordinate.Altitude);
            return $"{cityName} ===> {currentWeather}";
        }

        public string GetTomorrowWeather(string cityName)
        {
            var coordinate = cityLocationService.GetLocation(cityName);
            var tomorrowWeather = locationWeatherService.GetTomorrowWeather(coordinate.Latitude, coordinate.Altitude);
            return $"{cityName} ===> {tomorrowWeather}";
        }
    }
}
