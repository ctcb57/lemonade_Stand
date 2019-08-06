using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    static class UserInterface
    {
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Here are the rules to the game:");
            Console.WriteLine("  ");
            Console.WriteLine("You will start by purchasing any supplies you believe are necessary given weather conditions.");
            Console.WriteLine("After purchasing supplies, you will create your lemonade recipe and set your price.");
            Console.WriteLine("You will start the day which will simulate how much lemonade you sold.");
            Console.WriteLine("You must survive for seven days.");
            Console.WriteLine("   ");
            Console.WriteLine("Things to keep in mind:");
            Console.WriteLine("Customer demand will vary depending on the weather and your price.");
            Console.WriteLine("Ensure you have enough supplies to make it through the day.");
            Console.WriteLine("If you don't keep a positive cash balance, you will go bankrupt and lose the game");
            Console.WriteLine("   ");
            Console.WriteLine("Press ENTER to begin your game");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayPriceOptions()
        {
            Console.WriteLine("Welcome to the Store!");
            Console.WriteLine("  ");
            Console.WriteLine("Here is the list of items and their prices:");
            Console.WriteLine("Cups: $1 per cup");
            Console.WriteLine("Lemons: $3 per lemon");
            Console.WriteLine("Sugar: $2 per cup of sugar");
            Console.WriteLine("Ice: $1 per ice pack");
            Console.WriteLine("   ");
            Console.WriteLine("Please indicate how much of each item you would like to purchase");
            Console.ReadLine();
            //remove this read line at production time
        }

        public static void DisplayWeatherIntroduction()
        {
            Console.WriteLine("Here is the weather you will encounter today");
            Console.WriteLine("Remember, the weather will influence demand of your product");
            Console.ReadLine();
            //remove this readline at production time
        }

        public static void DisplayRecipeIntro()
        {
            Console.WriteLine("Now you need to generate your recipe.");
            Console.WriteLine("You will decide how many lemons and cups of sugar go into each pitcher");
            Console.WriteLine("Each pitcher will generate 10 cups of lemonade");
            Console.ReadLine();
            //remove this readline at production time
        }
    }
}
