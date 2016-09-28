using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    class WeatherDataServiceFactory 
    {
        enum WeatherWebServices { OPEN_WEATER_MAP, OTHER_SERIVCE };

        public IWeatherDataService getWeatherDataService(int weatherWebService)
        {
            switch (weatherWebService)
            {
                case (int)WeatherWebServices.OPEN_WEATER_MAP:
                     return new OpenWeatherMapDataService();
                case (int)WeatherWebServices.OTHER_SERIVCE:
                    return null; // return OTHER_SERVICE object
                default:
                    return null;
            }
        }
    }
}
