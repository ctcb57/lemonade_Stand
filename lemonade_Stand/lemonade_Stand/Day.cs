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
        public int dailyProfit;
        public int dailySales;

        //constructor
        public Day()
        {
            dailySales = 0;
        }
        //member methods
        public void DisplayDailyWeatherForecast(Weather weather)
        {
            weather.ForecastTemperature();
            weather.ForecastPrecipitation();
            Console.Clear();
        }

        public void DisplayDailyActualWeather(Weather weather)
        {
            weather.GenerateActualTemperature();
            weather.GenerateActualPrecipitation();
        }

        public void ShowDailySales(Player player)
        {
            Console.WriteLine(player.name + " earned $" + dailySales + " in sales today.");
            Console.ReadLine();
        }

        public void ShowDailyProfit(Store store, Player player)
        {
            dailyProfit = dailySales - store.totalPurchase;
            if (dailyProfit > 0)
            {
                Console.WriteLine(player.name + " had a total profit of $" + dailyProfit + " today.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player.name + " had a total loss of $" + dailyProfit + " today.");
                Console.ReadLine();
            }
        }

        public void ResetDailyData(Store store)
        {
            store.totalPurchase = 0;
            dailySales = 0;
        }



    }
}
