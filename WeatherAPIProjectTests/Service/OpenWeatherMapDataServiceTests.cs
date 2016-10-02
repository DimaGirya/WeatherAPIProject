using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherAPIProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPIProject.Service;

namespace WeatherAPIProject.Tests
{
    [TestClass()]
    public class OpenWeatherMapDataServiceTests
    {
    
        [TestMethod()]
        public void GetWeatherDataTest()
        {
            //arrange
            FakeWebDownloader fakeDownloader = new FakeWebDownloader();
            fakeDownloader.Result = @"
<current><city id=""295620"" name=""Ashqelon""><coord lon=""34.57"" lat=""31.67""></coord><country>IL</country><sun rise=""2016 - 10 - 02T03: 36:33"" set=""2016 - 10 - 02T15: 24:38""></sun></city><temperature value=""312.25"" min=""312.25"" max=""312.25"" unit=""kelvin""></temperature><humidity value=""17"" unit="" % ""></humidity><pressure value=""1012.831"" unit=""hPa""></pressure><wind><speed value=""4.56"" name=""Gentle Breeze""></speed><gusts></gusts><direction value=""94.5044"" code=""E"" name=""East""></direction></wind><clouds value=""0"" name=""clear sky""></clouds><visibility></visibility><precipitation mode=""no""></precipitation><weather number=""800"" value=""clear sky"" icon=""01d""></weather><lastupdate value=""2016 - 10 - 02T09: 34:36""></lastupdate></current>
";
            WeatherData expected = new WeatherData();
            expected.cloud = new Cloud();
            expected.cloud.name = "clear sky";
            expected.cloud.value = 0;
            expected.humidity = "17%";
            expected.lastUpdate = new DateTime(2016, 10, 02, 09, 34, 36);
            expected.pressure = 1012.831F;
            expected.sun = new Sun();
            expected.sun.Rise = DateTime.Parse("2016 - 10 - 02T03: 36:33");
            expected.sun.Set = DateTime.Parse("2016 - 10 - 02T15: 24:38");
            expected.temperature = 312.25F;
            expected.unit = "kelvin";
            expected.wind = new Wind();
            expected.wind.name = "Gentle Breeze";
            expected.wind.speed = 4.56F;

            OpenWeatherMapDataService openWeatherMapDataService  = new OpenWeatherMapDataService(fakeDownloader);
            Location location = new Location("Ashqelon");

            //act
            WeatherData actual = openWeatherMapDataService.GetWeatherData(location);

            //assert
            Assert.AreEqual(actual.cloud.name, expected.cloud.name);
            Assert.AreEqual(actual.cloud.value, expected.cloud.value);
            Assert.AreEqual(actual.humidity, expected.humidity);
            Assert.AreEqual(actual.lastUpdate, expected.lastUpdate);
            Assert.AreEqual(actual.pressure, expected.pressure);
            Assert.AreEqual(actual.sun.Rise, expected.sun.Rise);
            Assert.AreEqual(actual.sun.Set, expected.sun.Set);
            Assert.AreEqual(actual.temperature, expected.temperature);
            Assert.AreEqual(actual.unit, expected.unit);
            Assert.AreEqual(actual.wind.name, expected.wind.name);
            Assert.AreEqual(actual.wind.speed, expected.wind.speed);
            
        }
    }

    public class FakeWebDownloader : IWebDownloader
    {

        public string Result;

        public string Download(string url)
        {
            return Result;
        }
    }
}