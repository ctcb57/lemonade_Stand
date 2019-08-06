using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Game
    {
        //Things to do for the game
        //Generate the method for determining the profit within the game
        //the daily profit would be within the day class

        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
        public const int startingCash = 100;
        public int weeklyProfit;
        public Inventory player1Inventory;
        public Store player1Store;
        public Day dayOfTheWeek;
        public Weather weather;
        public Day day;
        public Stand player1Stand;
        //constructor
        public Game()
        {
            numberOfDaysThreshold = 7;
        }

        //member methods
        public void SetUpGame()
        {
            player1 = new Player();
            player1.ChooseName();
            player1Store = new Store();
            player1Inventory = new Inventory();
            weather = new Weather();
            day = new Day();
            player1Stand = new Stand();
        }

        public void PurchaseItems()
        {
            player1Store.SellLemons(player1, player1Inventory);
            player1.DisplayCashOnHand();
            player1Store.SellCup(player1, player1Inventory);
            player1.DisplayCashOnHand();
            player1Store.SellIce(player1, player1Inventory);
            player1.DisplayCashOnHand();
            player1Store.SellSugar(player1, player1Inventory);
            player1.DisplayCashOnHand();
            player1Inventory.DisplayItemCount();
            Console.Clear();
        }
        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
            UserInterface.DisplayWeatherIntroduction();
            day.DisplayDailyWeather();
            UserInterface.DisplayPriceOptions();
            PurchaseItems();
            UserInterface.DisplayRecipeIntro();
            player1Stand.CreateRecipe();
        }

    }
}
