using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
   public class Stand
    {
        //Need to generate a variable that holds the number of cups that are left within the pitcher
        //Need to create a method that recreates the pitcher and decreases inventory
        //Need to ensure that each time a cup is purchased, it decreases the number of cups left in the pitcher
        //member variables
        public int priceOfLemonade;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int icePerPitcher;
        public int cupsOfLemonadeLeftInPitcher;

        //constructor
        public Stand()
        {
        }
        //member methods
        public void CreateRecipe()
        {
            Console.WriteLine("How many lemons would you like to use per pitcher?");
            lemonsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar would you like to use per pitcher?");
            sugarPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice packs would you like to use per pitcher?");
            icePerPitcher = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public int SetLemondadePrice()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade?");
            priceOfLemonade = int.Parse(Console.ReadLine());
            return priceOfLemonade;
        }

        public void DetermineIfCustomerBuys(Customer customer, Weather weather, Player player)
        {
            customer.GenerateCustomerPreferences();
            if(customer.precipitationPreference == weather.precipitation && priceOfLemonade < customer.pricePreference && weather.temperature > customer.temperaturePreference)
            {
                player.cashOnHand += priceOfLemonade;
                Console.WriteLine("Customer " + customer.idNumber + " purchased lemonade");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Customer " + customer.idNumber + "didn't purchase lemonade");
                Console.ReadLine();
            }
        }
    }
}
