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
        public int totalPurchase;

        //constructor
        public Day()
        {
            dailySales = 0;
        }
        //member methods

        public int ShowDailyProfit()
        {
            dailyProfit = dailySales - totalPurchase;
            return dailyProfit;
        }

        public void ResetDailyData()
        {
            totalPurchase = 0;
            dailySales = 0;
        }



    }
}
