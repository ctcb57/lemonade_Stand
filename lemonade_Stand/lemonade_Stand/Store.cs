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
        public int lemon;
        public int ice;
        public int cup;
        public int sugar;
       

        //constructor
        public Store()
        {

        }

        //member methods
        public void SellLemons(Player player, Inventory inventory)
        {
            player.cashOnHand -= 3;
            inventory.lemonCount += 1;
        }

        public void SellIce(Player player, Inventory inventory)
        {
            player.cashOnHand -= 1;
            inventory.iceCount += 1;
        }

        public void SellSugar(Player player, Inventory inventory)
        {
            player.cashOnHand -= 2;
            inventory.sugarCount += 1;
        }

        public void SellCup(Player player, Inventory inventory)
        {
            player.cashOnHand -= 1;
            inventory.cupCount += 1;
        }

    }
}
