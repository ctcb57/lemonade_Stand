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
        public int dailyProfit;
        public int dailySales;

        //constructor
        public Day()
        {
            weather = new Weather();
            dailySales = 0;
        }
        //member methods
        public void DisplayDailyWeather()
        {
            weather.ForecastTemperature();
            weather.ForecastPrecipitation();
            Console.Clear();
        }

        public void ShowDailySales(Player player)
        {
            Console.WriteLine(player.name + " earned $" + dailySales + " in sales today.");
            Console.ReadLine();
            dailySales = 0;
        }



    }
}
