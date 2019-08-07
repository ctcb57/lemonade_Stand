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
            int lemonsPurchased = int.Parse(Console.ReadLine());
            if(player.cashOnHand < (lemonPrice * lemonsPurchased))
            {
                Console.WriteLine("You do not have enough cash to make that purchase");
                Console.WriteLine("Please select a lower amount of this item");
                Console.ReadLine();
                SellLemons(player, inventory);
                return 0;
            }
            else
            {
                player.cashOnHand -= (lemonPrice * lemonsPurchased);
                inventory.lemonCount += (1 * lemonsPurchased);
                int moneySpentOnLemons = lemonPrice * lemonsPurchased;
                return moneySpentOnLemons;
            } 
        }

        public int SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("How much ice would you like to purchase?");
            int icePurchased = int.Parse(Console.ReadLine());
            if(player.cashOnHand < (icePrice * icePurchased))
            {
                Console.WriteLine("You do not have enough cash to make that purchase");
                Console.WriteLine("Please select a lower amount of this item");
                Console.ReadLine();
                SellIce(player, inventory);
                return 0;
            }
            else
            {
                player.cashOnHand -= (icePrice * icePurchased);
                inventory.iceCount += (1 * icePurchased);
                int moneySpentOnIce = icePrice * icePurchased;
                return moneySpentOnIce;
            }
            
        }

        public int SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("How many sugar packs would you like to purchase?");
            int sugarPurchased = int.Parse(Console.ReadLine());
            if(player.cashOnHand < (sugarPrice * sugarPurchased))
            {
                Console.WriteLine("You do not have enough cash to make that purchase");
                Console.WriteLine("Please select a lower amount of this item");
                Console.ReadLine();
                SellSugar(player, inventory);
                return 0;
            }
            else
            {
                player.cashOnHand -= (sugarPrice * sugarPurchased);
                inventory.sugarCount += (1 * sugarPurchased);
                int moneySpentOnSugar = sugarPrice * sugarPurchased;
                return moneySpentOnSugar;
            }
        }


        public int SellCup(Player player, Inventory inventory)
        {
            Console.WriteLine("How many cups would you like to purchase?");
            int cupsPurchased = int.Parse(Console.ReadLine());
            if(player.cashOnHand < cupPrice)
            {
                Console.WriteLine("You do not have enough cash to make that purchase");
                Console.WriteLine("Please select a lower amount of this item");
                Console.ReadLine();
                SellCup(player, inventory);
                return 0;
            }
            else
            {
                player.cashOnHand -= (cupPrice * cupsPurchased);
                inventory.cupCount += (1 * cupsPurchased);
                int moneySpentOnCups = cupPrice * cupsPurchased;
                return moneySpentOnCups;
            }

            
        }

        public void PurchaseItems(Inventory inventory, Player player)
        {
            inventory.DisplayItemCount();
            if (player.cashOnHand >= lemonPrice)
            {
                int moneySpentOnLemons = SellLemons(player, inventory);
                player.DisplayCashOnHand();
                totalPurchase += moneySpentOnLemons;
                if(player.cashOnHand >= cupPrice)
                {
                    int moneySpentOnSugar = SellSugar(player, inventory);
                    player.DisplayCashOnHand();
                    totalPurchase += moneySpentOnSugar;

                    if (player.cashOnHand >= icePrice)
                    {
                        int moneySpentOnIce = SellIce(player, inventory);
                        player.DisplayCashOnHand();
                        totalPurchase += moneySpentOnIce;
                        if(player.cashOnHand >= sugarPrice)
                        {
                            int moneySpentOnCups = SellCup(player, inventory);
                            player.DisplayCashOnHand();
                            totalPurchase += moneySpentOnCups;
                        }
                        else
                        {
                            Console.WriteLine(player.name + " doesn't have enough money to purchase any other items.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine(player.name + " doesn't have enough money to purchase any other items.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine(player.name + " doesn't have enough money to purchase any other items.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine(player.name + " doesn't have enough money to purchase any other items.");
                Console.ReadLine();
            }
            inventory.DisplayItemCount();
            Console.WriteLine(player.name + " spent $" + totalPurchase + " on supplies today.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
