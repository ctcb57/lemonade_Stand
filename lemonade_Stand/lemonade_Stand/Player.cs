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
        public Stand
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


    }
}
