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
            UserInterface.LemonRecipePrompt();
            int lemonsPerPitcher;
            while (!int.TryParse(Console.ReadLine(), out lemonsPerPitcher) || lemonsPerPitcher > inventory.LemonCount || lemonsPerPitcher <= 0)
            {
                UserInterface.InvalidLemonRecipeEntry();
            }
            return lemonsPerPitcher;
        }

        public int GetAmountOfSugarUsedInRecipe(Inventory inventory)
        {
            UserInterface.SugarRecipePrompt();
            int sugarPerPitcher;
            while (!int.TryParse(Console.ReadLine(), out sugarPerPitcher) || sugarPerPitcher > inventory.SugarCount || sugarPerPitcher <= 0)
            {
                UserInterface.InvalidSugarRecipeEntry();
            }
            return sugarPerPitcher;
        }

        public int GetAmountOfIceUsedInRecipe(Inventory inventory)
        {
            UserInterface.IceRecipePrompt();
            int icePerPitcher;
            while (!int.TryParse(Console.ReadLine(), out icePerPitcher) || icePerPitcher > inventory.IceCount || icePerPitcher <= 0)
            {
                UserInterface.InvalidIceRecipeEntry();
            }
            return icePerPitcher;
        }

        
        public int SetLemonadePrice()
        {
            UserInterface.SetLemonadePricePrompt();
            while(!int.TryParse(Console.ReadLine(), out priceOfLemonade) || priceOfLemonade <= 0 || priceOfLemonade > 10)
            {
                UserInterface.InvalidLemonadePriceEntry();
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
                UserInterface.InvalidPourLemonadeResponse();
            }
        }

        public void DetermineIfCustomerBuys(Customer customer, Weather weather, Player player, Inventory inventory, Day day)
        {
            customer.GenerateCustomerPreferences();
            if (priceOfLemonade < customer.pricePreference && weather.actualTemperature > customer.temperaturePreference)
            {
                player.CashOnHand += priceOfLemonade;
                cupsOfLemonadeLeftInPitcher -= 1;
                inventory.CupCount -= 1;
                day.dailySales += priceOfLemonade;
                UserInterface.CustomerPurchased(customer, player);
            }
            else
            {
                UserInterface.CustomerDidNotPurchase(customer);
            }
        }
    }
}
