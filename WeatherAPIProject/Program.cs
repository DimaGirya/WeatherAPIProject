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
            System.Console.WriteLine(service.forTest("http://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&APPID=a0dfc9db3d55a51591963a9b491c51e9"));


        }
    }
}
