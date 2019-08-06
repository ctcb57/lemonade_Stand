using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Inventory
    {
        //this should track all of the counts for each of the given items the player has at any time
        //member variables

        public int lemonCount;
        public int sugarCount;
        public int cupCount;
        public int iceCount;

        //constructor
        public Inventory()
        {

        }
        //member variables
        public void DisplayItemCount()
        {
            Console.WriteLine("You currently have " + lemonCount + " lemons.");
            Console.WriteLine("You currently have " + sugarCount + " cups of sugar.");
            Console.WriteLine("You currently have " + cupCount + " cups.");
            Console.WriteLine("You currently have " + iceCount + " packs of ice");
            Console.ReadLine();
            //remove this at the time of turning in the project or putting everything together
        }

    }
}
