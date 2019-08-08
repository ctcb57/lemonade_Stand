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
        public int GetNumberOfLemonsUsedInRecipe(Inventory inventory)
        {
            inventory.DisplayItemCount();
            Console.WriteLine("How many lemons would you like to use per pitcher? You must use more than zero and less than you currently have");
            int lemonsPerPitcher;
            while (!int.TryParse(Console.ReadLine(), out lemonsPerPitcher) || lemonsPerPitcher > inventory.LemonCount || lemonsPerPitcher <= 0)
            {
                Console.WriteLine("That's an invalid response");
                Console.WriteLine("How many lemons would you like to use per pitcher? You must use more than zero and less than you currently have");
            }
            Console.Clear();
            return lemonsPerPitcher;
        }

        public int GetAmountOfSugarUsedInRecipe(Inventory inventory)
        {
            inventory.DisplayItemCount();
            Console.WriteLine("How many cups of sugar would you like to use per pitcher? You must use more than zero and less than you currently have");
            int sugarPerPitcher;
            while (!int.TryParse(Console.ReadLine(), out sugarPerPitcher) || sugarPerPitcher > inventory.SugarCount || sugarPerPitcher <= 0)
            {
                Console.WriteLine("That's an invalid response");
                Console.WriteLine("How many cups of sugar would you like to use per pitcher? You must use more than zero and less than you currently have");
            }
            Console.Clear();
            return sugarPerPitcher;
        }

        public int GetAmountOfIceUsedInRecipe(Inventory inventory)
        {
            inventory.DisplayItemCount();
            Console.WriteLine("How many ice packs would you like to use per pitcher? You must use more than zero and less than you currently have");
            int icePerPitcher;
            while (!int.TryParse(Console.ReadLine(), out icePerPitcher) || icePerPitcher > inventory.IceCount || icePerPitcher <= 0)
            {
                Console.WriteLine("That's an invalid response");
                Console.WriteLine("How many ice packs would you like to use per pitcher? You must use more than zero and less than you currently have");
            }
            Console.Clear();
            return icePerPitcher;
        }

        
        public int SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade? Set the price between $1 and $10");
            while(!int.TryParse(Console.ReadLine(), out priceOfLemonade) || priceOfLemonade <= 0 || priceOfLemonade > 10)
            {
                Console.WriteLine("That's an invalid response");
                Console.WriteLine(" ");
                Console.WriteLine("How much would you like to charge per cup of lemonade?  Set the price between $1 and $10");
            }
            Console.Clear();
            return priceOfLemonade;
        }

        public void GenerateLemonadeRecipeAndPrice(Inventory inventory)
        {
            lemonsPerPitcher = GetNumberOfLemonsUsedInRecipe(inventory);
            sugarPerPitcher = GetAmountOfSugarUsedInRecipe(inventory);
            icePerPitcher = GetAmountOfIceUsedInRecipe(inventory);
            priceOfLemonade = SetLemonadePrice();

        }

        public void PourLemonadePitcher(Inventory inventory)
        {
            if (inventory.LemonCount > 0 && inventory.IceCount > 0 && inventory.SugarCount > 0 && inventory.CupCount > 9)
            {
                inventory.LemonCount -= lemonsPerPitcher;
                inventory.IceCount -= icePerPitcher;
                inventory.SugarCount -= sugarPerPitcher;
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
                inventory.CupCount -= 1;
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
