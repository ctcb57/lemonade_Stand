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
        public int cashOnHand;
        public int startingCash;

        //constructor
        public Player()
        {
            startingCash = 100;
            cashOnHand = 100;
        }
        //member methods
        public string ChooseName()
        {
            Console.WriteLine("Choose your player's name:");
            name = Console.ReadLine().Trim();
            Console.Clear();
            return name;
        }

        public int DisplayCashOnHand()
        {
            Console.WriteLine(name + "'s current cash on hand is: " + cashOnHand);
            Console.ReadLine();
            //delete readline at time of game
            return cashOnHand;
        }

    }
}
