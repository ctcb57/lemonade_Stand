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
        public int itemCounter;

        //constructor
        public Inventory(string item, int itemCounter)
        {
            Inventory lemon = new Inventory("lemon", 0);
            Inventory cup = new Inventory("cup", 0);
            Inventory sugar = new Inventory("sugar", 0);
            Inventory ice = new Inventory("ice", 0);
        }
        //member 
        //public int increaseInventoryCount()
        //{

        //}

    }
}
