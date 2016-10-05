using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIProject
{
    public class WeaterDataServiceExeption:Exception //need to chek if it's ok
    {
        private string _message;

        public WeaterDataServiceExeption(string message)
        {
            _message  = message;
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }

        public override string ToString()
        {
            return string.Format("Weater data service exeption {0}", Message);
        }

    }
}
