using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Day
    {
        //member variables
        Weather weather;
        //constructor
        public Day()
        {
            weather = new Weather();
        }
        //member methods
        public void DisplayDailyWeather()
        {
            weather.GenerateTemperature();
            weather.DeterminePrecipitation();
            Console.Clear();
        }



    }
}
