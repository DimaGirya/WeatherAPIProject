using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            string data = DownloadWeatherXml("http://api.openweathermap.org/data/2.5/weather?q=" + location.locationName + "&mode=xml&APPID=a0dfc9db3d55a51591963a9b491c51e9");
            return null;


        }


        public string DownloadWeatherXml(string url)
        {
            string wheatherXml = String.Empty;
            WebClient client = new WebClient();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            wheatherXml = reader.ReadToEnd();
            return wheatherXml;
        }
    }
}
