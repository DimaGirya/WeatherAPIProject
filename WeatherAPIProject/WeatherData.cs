using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    class WeatherData
    {
        private float temperature { get; set; }
        private string unit { get; set; }
        private float humidity { get; set; }
        private float visibilityValue { get; set; }
        private float pressure { get; set; }
        private Wind wind { get; set; }
        private Cloud cloud { get; set; }
        private Sun sun { get; set; }
        DateTime lastUpdate { get; set; }
    }
}
