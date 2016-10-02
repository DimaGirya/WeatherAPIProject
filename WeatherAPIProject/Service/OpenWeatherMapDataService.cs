using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeatherAPIProject.Service;

namespace WeatherAPIProject
{
    public class OpenWeatherMapDataService : IWeatherDataService 
    {
        private IWebDownloader webDownloader;

        public OpenWeatherMapDataService(IWebDownloader webDownloader)
        {
            this.webDownloader = webDownloader;
        }

        public WeatherData GetWeatherData(Location location)
        {
            string data = DownloadWeatherXml("http://api.openweathermap.org/data/2.5/weather?q=" + location.locationName + "&mode=xml&APPID=a0dfc9db3d55a51591963a9b491c51e9");

            //TODO: to do check if xml is legal 
            // validateResponse();
            
            string myXML = @data;
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            XElement xelement = XElement.Parse(data);

            WeatherData weatherData = new WeatherData();
            weatherData.sun = new Sun();
            weatherData.sun.Rise=DateTime.Parse(xelement.Element("city").Element("sun").Attribute("rise").Value);
            weatherData.sun.Set = DateTime.Parse(xelement.Element("city").Element("sun").Attribute("set").Value);
            weatherData.temperature = float.Parse(xelement.Element("temperature").Attribute("value").Value);
            weatherData.unit = xelement.Element("temperature").Attribute("unit").Value;
            weatherData.humidity = xelement.Element("humidity").Attribute("value").Value+"%";
            weatherData.pressure = float.Parse(xelement.Element("pressure").Attribute("value").Value);
            Wind wind = new Wind();
            wind.speed = float.Parse(xelement.Element("wind").Element("speed").Attribute("value").Value);
            wind.name = xelement.Element("wind").Element("speed").Attribute("name").Value;
            weatherData.wind = wind;
            Cloud clouds = new Cloud();
            clouds.value = float.Parse(xelement.Element("clouds").Attribute("value").Value);
            clouds.name = xelement.Element("clouds").Attribute("name").Value;
            weatherData.cloud = clouds;
            weatherData.lastUpdate = DateTime.Parse(xelement.Element("lastupdate").Attribute("value").Value);
            return weatherData;
        }
        
        private string DownloadWeatherXml(string url)
        {
            return webDownloader.Download(url);
        }

        private void ValidateResponse(string response)
        {
            //TODO: implement it!!!
        }
    }
    
}
