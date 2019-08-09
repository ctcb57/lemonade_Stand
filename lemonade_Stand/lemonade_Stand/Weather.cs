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
            return forecastedTemperature;
        }

        public bool ForecastPrecipitation()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if(number == 0)
            {
                forecastedPrecipitation = true;
                return forecastedPrecipitation;
            }
            else
            {
                forecastedPrecipitation = false;
                return forecastedPrecipitation;
            }
        }

        public int GenerateActualTemperature()
        {
            Random random = new Random();
            actualTemperature = random.Next((forecastedTemperature - 5), (forecastedTemperature +5));
            return actualTemperature;
        }

        public bool GenerateActualPrecipitation()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                actualPrecipitation = true;
                return actualPrecipitation;
            }
            else
            {
                actualPrecipitation = false;
                return actualPrecipitation;
            }
        }
    }
}
