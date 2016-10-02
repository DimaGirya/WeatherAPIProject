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
            IWeatherDataService service = new WeatherDataServiceFactory().GetWeatherDataService(WeatherWebServices.OPEN_WEATER_MAP);

            var result = service.GetWeatherData(new Location("TelAviv"));

        }
    }
}
