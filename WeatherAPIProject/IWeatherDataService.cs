﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
    }
}
