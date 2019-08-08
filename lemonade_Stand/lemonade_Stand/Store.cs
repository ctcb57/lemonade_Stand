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
        //public int totalPurchase;

        //constructor
        public Store()
        {
            lemonPrice = 3;
            icePrice = 1;
            cupPrice = 1;
            sugarPrice = 2;
        }

        //member methods
        public int SellLemons(Player player, Inventory inventory)
        {
            UserInterface.PurchaseLemonsPrompt();
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.CashOnHand < (lemonPrice * response))
            {
                UserInterface.InvalidLemonResponse();
            }
            player.CashOnHand -= (lemonPrice * response);
            inventory.LemonCount += (1 * response);
            int moneySpentOnLemons = lemonPrice * response;
            return moneySpentOnLemons;
        }

        public int SellIce(Player player, Inventory inventory)
        {
            UserInterface.PurchaseIcePrompt();
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.CashOnHand < (icePrice * response))
            {
                UserInterface.InvalidIceResponse();
            }
            player.CashOnHand -= (icePrice * response);
            inventory.IceCount += (1 * response);
            int moneySpentOnIce = icePrice * response;
            return moneySpentOnIce;
        }

        public int SellSugar(Player player, Inventory inventory)
        {
            UserInterface.PurchaseSugarPrompt();
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.CashOnHand < (sugarPrice * response))
            {
                UserInterface.InvalidSugarResponse();
            }
            player.CashOnHand -= (sugarPrice * response);
            inventory.SugarCount += (1 * response);
            int moneySpentOnSugar = sugarPrice * response;
            return moneySpentOnSugar;
        }

        public int SellCups(Player player, Inventory inventory)
        {
            UserInterface.PurchaseCupsPrompt();
            int response;

            while (!int.TryParse(Console.ReadLine(), out response) || player.CashOnHand < (cupPrice * response))
            {
                UserInterface.InvalidCupsResponse();
            }
            player.CashOnHand -= (cupPrice * response);
            inventory.CupCount += (1 * response);
            int moneySpentOnCups = cupPrice * response;
            return moneySpentOnCups;
        }

        public int PurchaseItems(Player player, Inventory inventory, Day day)
        {
            UserInterface.DisplayCashOnHand(player);
            int moneySpentOnLemons = SellLemons(player, inventory);
            UserInterface.DisplayCashOnHand(player);
            int moneySpentOnIce = SellIce(player, inventory);
            UserInterface.DisplayCashOnHand(player);
            int moneySpentOnSugar = SellSugar(player, inventory);
            UserInterface.DisplayCashOnHand(player);
            int moneySpentOnCups = SellCups(player, inventory);
            UserInterface.DisplayCashOnHand(player);
            day.totalPurchase = moneySpentOnCups + moneySpentOnIce + moneySpentOnLemons + moneySpentOnSugar;
            return day.totalPurchase;
        }
    }
}
