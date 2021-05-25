namespace Facade
{
    public class CityLocationService
    {
        internal GeoCoordinate GetLocation(string cityName)
        {
            return new GeoCoordinate { Latitude = 0, Altitude = 0 };
        }
    }
}