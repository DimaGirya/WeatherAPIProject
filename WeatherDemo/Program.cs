using System;
using WeatherAPIProject;
namespace WeatherDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWeatherDataService weatherDataService = new WeatherDataServiceFactory().GetWeatherDataService(WeatherWebServicesTypes.OPEN_WEATER_MAP);
            }
            catch (WeaterDataServiceExeption ex)
            {
                Console.WriteLine("error " + ex.Message);
            }

            try
            {
                Location location = new Location("TelAviv");
                IWeatherDataService service = new WeatherDataServiceFactory().GetWeatherDataService(WeatherWebServicesTypes.OPEN_WEATER_MAP);
                var result = service.GetWeatherData(location);
                printWeather(result,location);
            }
            catch (WeaterDataServiceExeption ex)
            {
                Console.WriteLine("WeaterDataServiceExeption error" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        private static void printWeather(WeatherData result,Location location)
        {
            Console.WriteLine("Weather in "+ location.locationName + ":");
            Console.WriteLine("Temperature (on "+result.unit + " unit):");
            Console.WriteLine(result.temperature);
            Console.WriteLine("Cloud:");
            Console.WriteLine(result.cloud.name);
            Console.WriteLine(result.cloud.value);
            Console.WriteLine("Humidity:");
            Console.WriteLine(result.humidity);
            Console.WriteLine("Pressure:");
            Console.WriteLine(result.pressure);
            Console.WriteLine("Sun rise:");
            Console.WriteLine(result.sun.Rise);
            Console.WriteLine("Sun set:");
            Console.WriteLine(result.sun.Set);
        }
    }
}
