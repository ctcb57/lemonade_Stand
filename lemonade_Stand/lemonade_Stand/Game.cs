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
        //need to create a method which tracks the actual daily totals
        //this means that it just needs to show how much in actual sales you actually made
        //need to create a method which creates a forecast for the day which will display at the start of the day
        //need to then create a method which shows the actual weather - should be close to the forecast for playability sake
        //need to have the day class distinguish the difference between profit and loss for the day
        //need to input some set and get logic for the game to prevent the player from going into the negative
        //need to work on making the math work in a logical way - consider switching all variables to doubles
        //clean up the code so it looks and operates much more clean


        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
        public int dayNumber;
        public const int startingCash = 100;
        public int weeklyProfit;
        public Inventory player1Inventory;
        public Store player1Store;
        public Day dayOfTheWeek;
        public Weather weather;
        public Day day;
        public Stand player1Stand;
        public Customer player1Customer;
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
            player1Customer = new Customer();
        }

        public void PurchaseItems()
        {
            player1Inventory.DisplayItemCount();
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

        public void CalcWeeklyProfit()
        {
            weeklyProfit = player1.cashOnHand - player1.startingCash;
            Console.WriteLine(player1.name + " has earned " + weeklyProfit + " this week.");
            Console.ReadLine();
        }
        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
            for(dayNumber = 1 ; dayNumber <= numberOfDaysThreshold; dayNumber++)
            {
                Console.WriteLine("Today is day number " + dayNumber + " of " + numberOfDaysThreshold);
                UserInterface.DisplayWeatherIntroduction();
                weather.DeterminePrecipitation();
                weather.GenerateTemperature();
                Console.Clear();
                UserInterface.DisplayPriceOptions();
                PurchaseItems();
                UserInterface.DisplayRecipeIntro();
                player1Stand.CreateRecipe();
                player1Stand.SetLemondadePrice();
                player1Stand.PourLemonadePitcher(player1Inventory);
                for (int i = 0; i < 20; i++)
                {
                    player1Stand.DetermineIfCustomerBuys(player1Customer, weather, player1, player1Inventory);
                }
                Console.ReadLine();
                Console.Clear();
                UserInterface.DisplayEndOfDaySummary();
                player1Inventory.DisplayItemCount();
                day.CalcDailyProfit(player1);
                CalcWeeklyProfit();
                Console.Clear();
            }
        }

    }
}
