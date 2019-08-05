using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    class Inventory
    {
        //member variables
        public string item;
        public double price;
        public int itemCounter;

        //constructor
        public Inventory(string item, double price, int itemCounter)
        {
            Inventory lemon = new Inventory("lemon", 0.4, 0);
            Inventory cup = new Inventory("cup", 0.05, 0);
            Inventory sugar = new Inventory("sugar", 0.25, 0);
            Inventory ice = new Inventory("ice", 0.01, 0);
        }
        //member methods

    }
}
