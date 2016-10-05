using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new WeatherDataServiceFactory().GetWeatherDataService(WeatherWebServicesTypes.OTHER_SERIVCE);
            }
            catch (WeaterDataServiceExeption ex)
            {
                Console.WriteLine("error " + ex.Message);
            }

            try
            {
                IWeatherDataService service = new WeatherDataServiceFactory().GetWeatherDataService(WeatherWebServicesTypes.OPEN_WEATER_MAP);

                var result = service.GetWeatherData(new Location("TelAviv"));

            }
            catch (WeaterDataServiceExeption ex)
            {
                Console.WriteLine("WeaterDataServiceExeption error" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
