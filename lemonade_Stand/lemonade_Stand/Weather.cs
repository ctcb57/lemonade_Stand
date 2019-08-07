using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Weather
    {
        // open weather
        // yahoo weather

        // C# how to make api call
        // make a separate class

        //member variables
        public int forecastedTemperature;
        public bool forecastedPrecipitation;
        public int actualTemperature;
        public bool actualPrecipitation;
        //constructor
        public Weather()
        {

        }
        //member methods
        public int ForecastTemperature()
        {
            Random random = new Random();
            forecastedTemperature = random.Next(70, 101);
            Console.WriteLine("Projected temperatue is: " + forecastedTemperature + " degrees");
            Console.ReadLine();
            return forecastedTemperature;
            //remove the readline at production time
        }

        public bool ForecastPrecipitation()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if(number == 0)
            {
                forecastedPrecipitation = true;
                Console.WriteLine("There is rain in the forecast for today");
                Console.ReadLine();
                //remove the readline at production time
                return forecastedPrecipitation;
            }
            else
            {
                forecastedPrecipitation = false;
                Console.WriteLine("There is no rain in the forecast for today");
                Console.ReadLine();
                //remove the readline at production time
                return forecastedPrecipitation;
            }
        }

        public int GenerateActualTemperature()
        {
            Random random = new Random();
            actualTemperature = random.Next((forecastedTemperature - 5), (forecastedTemperature +5));
            Console.WriteLine("The temperature will be " + actualTemperature + " degrees today");
            Console.ReadLine();
            return actualTemperature;
        }

        public bool GenerateActualPrecipitation()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                actualPrecipitation = true;
                Console.WriteLine("It will rain today");
                Console.ReadLine();
                //remove the readline at production time
                return actualPrecipitation;
            }
            else
            {
                actualPrecipitation = false;
                Console.WriteLine("No rain today");
                Console.ReadLine();
                //remove the readline at production time
                return actualPrecipitation;
            }
        }
    }
}
