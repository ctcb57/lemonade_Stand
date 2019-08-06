using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Weather
    {
        //member variables
        public int temperature;
        public bool precipitation;
        //constructor
        public Weather()
        {
            temperature = 0;
            precipitation = false;
        }
        //member methods
        public int GenerateTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(50, 101);
            Console.WriteLine("Projected temperatue is: " + temperature + " degrees");
            Console.ReadLine();
            return temperature;
            //remove the readline at production time
        }

        public bool DeterminePrecipitation()
        {
            Random random = new Random();
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
