using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    public class Location
    {
        public String locationName { get; set; }

        public Location(string locationName)
        {
            this.locationName = locationName;
        }

        
    }
}
