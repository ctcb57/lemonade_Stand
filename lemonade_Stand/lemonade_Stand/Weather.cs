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
        public Weather()
        {
            random = new Random();
        }
        //member methods
        public int GenerateTemperature()
        {
            int temperature = random.Next(50, 101);
            Console.WriteLine("Projected temperatue is: " + temperature + " degrees");
            Console.ReadLine();
            //remove the readline at production time
            return temperature;
        }

        public bool DeterminePrecipitation()
        {
            int number = random.Next(0, 2);
            if(number == 0)
            {
                precipitation = true;
                Console.WriteLine("There is rain in the forecast for today");
                Console.ReadLine();
                //remove the readline at production time
                return precipitation;
            }
            else
            {
                precipitation = false;
                Console.WriteLine("There is no rain in the forecast for today");
                Console.ReadLine();
                //remove the readline at production time
                return precipitation;
            }
        }
    }
}
