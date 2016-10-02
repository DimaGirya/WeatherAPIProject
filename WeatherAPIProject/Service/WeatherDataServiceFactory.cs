using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPIProject.Service;

namespace WeatherAPIProject
{
    class WeatherDataServiceFactory 
    {
        
        public IWeatherDataService GetWeatherDataService(WeatherWebServices weatherWebService)
        {
            switch (weatherWebService)
            {
                case WeatherWebServices.OPEN_WEATER_MAP:
                     return new OpenWeatherMapDataService(new WebDownloader());
                case WeatherWebServices.OTHER_SERIVCE:
                    return null; // return OTHER_SERVICE object
                default:
                    return null;
            }
        }
    }
    enum WeatherWebServices { OPEN_WEATER_MAP, OTHER_SERIVCE };


}
