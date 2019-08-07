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
        public int lemonPrice;
        public int icePrice;
        public int cupPrice;
        public int sugarPrice;
        public int totalPurchase;

        //constructor
        public Store()
        {
            lemonPrice = 3;
            icePrice = 1;
            cupPrice = 1;
            sugarPrice = 2;
            totalPurchase = 0;
        }

        //member methods
        public int SellLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int response;

            while(!int.TryParse(Console.ReadLine(), out response) || player.cashOnHand < (lemonPrice * response))
            {
                Console.WriteLine("You entered an invalid amount");
                Console.WriteLine("How many lemons would you like to purchase?");
            }
            player.cashOnHand -= (lemonPrice * response);
            inventory.LemonCount += (1 * response);
            int moneySpentOnLemons = lemonPrice * response;
            return moneySpentOnLemons;
        }

        public int SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("How many ice packs would you like to purchase?");
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.cashOnHand < (icePrice * response))
            {
                Console.WriteLine("You entered an invalid amount");
                Console.WriteLine("How many ice packs would you like to purchase?");
            }
            player.cashOnHand -= (icePrice * response);
            inventory.IceCount += (1 * response);
            int moneySpentOnIce = icePrice * response;
            return moneySpentOnIce;
        }

        public int SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar would you like to purchase?");
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.cashOnHand < (sugarPrice * response))
            {
                Console.WriteLine("You entered an invalid amount");
                Console.WriteLine("How many cups of sugar would you like to purchase?");
            }
            player.cashOnHand -= (sugarPrice * response);
            inventory.SugarCount += (1 * response);
            int moneySpentOnSugar = sugarPrice * response;
            return moneySpentOnSugar;
        }

        public int SellCups(Player player, Inventory inventory)
        {
            Console.WriteLine("How many cups would you like to purchase?");
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.cashOnHand < (cupPrice * response))
            {
                Console.WriteLine("You entered an invalid amount");
                Console.WriteLine("How many cups would you like to purchase?");
            }
            player.cashOnHand -= (cupPrice * response);
            inventory.CupCount += (1 * response);
            int moneySpentOnCups = cupPrice * response;
            return moneySpentOnCups;
        }


        public void PurchaseItems(Inventory inventory, Player player)
        {
            inventory.DisplayItemCount();
            player.DisplayCashOnHand();
            int moneySpentOnLemons = SellLemons(player, inventory);
            player.DisplayCashOnHand();
            int moneySpentOnSugar = SellSugar(player, inventory);
            player.DisplayCashOnHand();
            int moneySpentOnIce = SellIce(player, inventory);
            player.DisplayCashOnHand();
            int moneySpentOnCups = SellCups(player, inventory);
            player.DisplayCashOnHand();
            totalPurchase = moneySpentOnLemons + moneySpentOnSugar + moneySpentOnIce + moneySpentOnCups;
            inventory.DisplayItemCount();
            Console.WriteLine(player.name + " spent $" + totalPurchase + " on supplies today.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
