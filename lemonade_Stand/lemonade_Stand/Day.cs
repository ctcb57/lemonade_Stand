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

        public int CalcDailyProfit(Player player)
        {
            dailyProfit = player.cashOnHand - player.startingCash;
            Console.WriteLine(player.name + " earned " + dailyProfit + " in profit today.");
            Console.ReadLine();
            return dailyProfit;
        }



    }
}
