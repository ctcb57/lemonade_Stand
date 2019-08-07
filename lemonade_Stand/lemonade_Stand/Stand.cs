using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
   public class Stand
    {
        
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

        public void PourLemonadePitcher(Inventory inventory)
        {
            if (inventory.lemonCount > 0 && inventory.iceCount > 0 && inventory.sugarCount > 0 && inventory.cupCount > 9)
            {
                inventory.lemonCount -= lemonsPerPitcher;
                inventory.iceCount -= icePerPitcher;
                inventory.sugarCount -= sugarPerPitcher;
                cupsOfLemonadeLeftInPitcher = 10;
            }
            else
            {
                Console.WriteLine("You do not have enough inventory to pour another pitcher of lemonade");
                Console.WriteLine("You will not be able to sell to another customer today.");
                Console.ReadLine();
            }
        }

        public void DetermineIfCustomerBuys(Customer customer, Weather weather, Player player, Inventory inventory, Day day)
        {
            customer.GenerateCustomerPreferences();
            if (priceOfLemonade < customer.pricePreference && weather.actualTemperature > customer.temperaturePreference)
            {
                player.cashOnHand += priceOfLemonade;
                cupsOfLemonadeLeftInPitcher -= 1;
                inventory.cupCount -= 1;
                day.dailySales += priceOfLemonade;
                Console.WriteLine("Customer " + customer.idNumber + " purchased lemonade");
                Console.WriteLine("You now have " + player.cashOnHand + " dollars of cash on hand");
                Console.WriteLine("There are " + cupsOfLemonadeLeftInPitcher + " cups of lemonade left in the pitcher");
                //remove the above line when you are ready for production since it is only checking that the method is working
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Customer " + customer.idNumber + " didn't purchase lemonade");
                Console.ReadLine();
            }
        }
    }
}
