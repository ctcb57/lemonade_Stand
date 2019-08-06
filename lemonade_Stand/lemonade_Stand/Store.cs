using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    class Store
    {
        //member variables
        public string item;
        public double price;

        //constructor
        public Store(string item, double price)
        {
            Store lemon = new Store("lemon", 0.4);
            Store cup = new Store("cup", 0.05);
            Store sugar = new Store("sugar", 0.25);
            Store ice = new Store("ice", 0.01);
        }

        //member methods
    }
}
