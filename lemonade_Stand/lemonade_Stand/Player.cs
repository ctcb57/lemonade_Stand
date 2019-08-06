using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Player
    {
        //member variables
        public string name;
        public double cashOnHand;

        //constructor
        public Player()
        {
            cashOnHand = 20.00;
        }
        //member methods
        public string ChooseName()
        {
            Console.WriteLine("Choose your player's name:");
            name = Console.ReadLine().Trim();
            Console.Clear();
            return name;
        }

        public void DisplayCashOnHand()
        {
            Console.WriteLine("Current Cash On Hand is: " + cashOnHand);
            Console.ReadLine();
            //Remove this readline whenever you're done with the program
        }

        public double PurchaseLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            double lemonsPurchased = double.Parse(Console.ReadLine());
            double purhcaseAmount = lemonsPurchased * .40;
            double currentCashOnHand = cashOnHand;
            cashOnHand = currentCashOnHand - purhcaseAmount;
            Console.WriteLine("Current cash on hand is: " + cashOnHand);
            Console.ReadLine();
            //remove this readline when you're done
            return cashOnHand;
        }

        


    }
}
