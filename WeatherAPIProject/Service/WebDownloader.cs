using System;
using System.IO;
using System.Net;


namespace WeatherAPIProject.Service
{
    public class WebDownloader : IWebDownloader
    {
        public string Download(string url)
        {
            string str = String.Empty;
            WebClient client = new WebClient();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            str = reader.ReadToEnd();
            return str;
        }
    }
}
