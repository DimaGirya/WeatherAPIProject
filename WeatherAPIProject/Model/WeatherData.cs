using System;

namespace WeatherAPIProject
{
    public class WeatherData
    {
        public float temperature { get; set; }
        public string unit { get; set; }
        public string humidity { get; set; }
        public float pressure { get; set; }
        public Wind wind { get; set; }
        public Cloud cloud { get; set; }
        public Sun sun { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}
