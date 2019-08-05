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
            Console.WriteLine("Cups: $0.05 per cup");
            Console.WriteLine("Lemons: $0.40 per lemon");
            Console.WriteLine("Sugar: $0.25 per cup of sugar");
            Console.WriteLine("Ice: $0.01 per ice cube");
            Console.WriteLine("   ");
            Console.WriteLine("Please indicate how much of each item you would like to purchase");
        }
    }
}
