using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WeatherAPIProject
{
    class OpenWeatherMapDataService : IWeatherDataService 
    {
        private static OpenWeatherMapDataService instance;

        private OpenWeatherMapDataService() { }

        public static OpenWeatherMapDataService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OpenWeatherMapDataService();
                }
                return instance;
            }
        }
        public WeatherData GetWeatherData(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
