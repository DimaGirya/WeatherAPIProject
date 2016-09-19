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
            OpenWeatherMapDataService service = OpenWeatherMapDataService.Instance;
            System.Console.WriteLine(service.GetWeatherData(new Location("London")));
            

        }
    }
}
