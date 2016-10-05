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
        
        public IWeatherDataService GetWeatherDataService(WeatherWebServicesTypes weatherWebService)
        {
            switch (weatherWebService)
            {
                case WeatherWebServicesTypes.OPEN_WEATER_MAP:
                     return new OpenWeatherMapDataService(new WebDownloader());
                case WeatherWebServicesTypes.OTHER_SERIVCE:
                default:
                    throw new WeaterDataServiceExeption("Unsupported service type "+ weatherWebService.ToString());
            }
        }
    }
    enum WeatherWebServicesTypes { OPEN_WEATER_MAP, OTHER_SERIVCE };


}
