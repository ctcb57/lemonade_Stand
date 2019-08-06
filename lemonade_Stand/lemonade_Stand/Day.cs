using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    class Day
    {
        //member variables
        public List<string> dayOfTheWeek;
        Weather weather;
        //constructor
        public Day()
        {
            dayOfTheWeek.Add("Monday");
            dayOfTheWeek.Add("Tuesday");
            dayOfTheWeek.Add("Wednesday");
            dayOfTheWeek.Add("Thursday");
            dayOfTheWeek.Add("Friday");
            dayOfTheWeek.Add("Saturday");
            dayOfTheWeek.Add("Sunday");
            weather = new Weather();
        }
        //member methods

    }
}
