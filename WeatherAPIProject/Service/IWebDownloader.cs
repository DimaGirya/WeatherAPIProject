using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject.Service
{
    public interface IWebDownloader
    {
        string Download(string url);
    }
}
