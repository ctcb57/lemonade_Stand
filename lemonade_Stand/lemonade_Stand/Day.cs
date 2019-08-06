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
        //public List<string> dayOfTheWeek;
        Weather weather;
        //constructor
        public Day()
        {
            //    dayOfTheWeek.Add("Monday");
            //    dayOfTheWeek.Add("Tuesday");
            //    dayOfTheWeek.Add("Wednesday");
            //    dayOfTheWeek.Add("Thursday");
            //    dayOfTheWeek.Add("Friday");
            //    dayOfTheWeek.Add("Saturday");
            //    dayOfTheWeek.Add("Sunday");
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
