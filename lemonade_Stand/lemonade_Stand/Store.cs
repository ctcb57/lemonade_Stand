using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Store
    {
        //member variables
       

        //constructor
        public Store()
        {

        }

        //member methods
        public void SellLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemonsPurchased = int.Parse(Console.ReadLine());
            player.cashOnHand -= (3 * lemonsPurchased);
            inventory.lemonCount += (1 * lemonsPurchased);
        }

        public void SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("How much ice would you like to purchase?");
            int icePurchased = int.Parse(Console.ReadLine());
            player.cashOnHand -= (1 * icePurchased);
            inventory.iceCount += (1 * icePurchased);
        }

        public void SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("How many sugar packs would you like to purchase?");
            int sugarPurchased = int.Parse(Console.ReadLine());
            player.cashOnHand -= (2 * sugarPurchased);
            inventory.sugarCount += (1 * sugarPurchased);
        }

        public void SellCup(Player player, Inventory inventory)
        {
            Console.WriteLine("How many cups would you like to purchase?");
            int cupsPurchased = int.Parse(Console.ReadLine());
            player.cashOnHand -= (1 * cupsPurchased);
            inventory.cupCount += (1 * cupsPurchased);
        }

    }
}
