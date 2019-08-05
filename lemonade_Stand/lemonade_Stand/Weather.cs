using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    class Weather
    {
        //member variables
        public int temperature;
        public bool precipitation;
        Random random;
        //constructor

        //member methods
        public int GenerateTemperature()
        {
            int temperature = random.Next(50, 101);
            return temperature;
        }

        public bool DeterminePrecipitation()
        {
            int number = random.Next(0, 2);
            if(number == 0)
            {
                precipitation = true;
                return precipitation;
            }
            else
            {
                precipitation = false;
                return precipitation;
            }
        }
    }
}
