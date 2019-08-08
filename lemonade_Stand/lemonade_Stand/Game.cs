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
        //AFTER LUNCH - KEEP FINISHING THE USER INTERFACE CLASS
        //need to put the inventory class in either the player or stand class - AFTER RANDOM FIX
        //need to put the stand class in the player class - AFTER RANDOM FIX
        //need to create a global random variable - AFTER USER INTERFACE
        //Need to ensure that all of of the console.writelines are located within the user interface - CURRENTLY WORKING
        //need to work on making the math work in a logical way - consider switching all variables to doubles
        //need to work on user input verification measures to prevent user input errors - STILL WORKING
        //need to work on ensuring some variables are private and others are public so your security is up - PARTIALLY COMPLETE, CHECK WITH INSTRUCTOR
        //need to rewrite the game so it allows for multiplayer or AI
        //need to figure out how to incorporate the weather API



        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
        public int dayNumber;
        public int weeklyProfit;
        public int startingCash;
        public Inventory player1Inventory; // playerOR stand class
        public Store player1Store;
        public Day day;
        public Stand player1Stand; // player class
        public Customer player1Customer;
        public Weather weather;
        //constructor
        public Game()
        {
            numberOfDaysThreshold = 7;
            startingCash = 100;
        }

        //member methods
        public void SetUpGame()
        {
            player1 = new Player();
            UserInterface.DisplayNameChoice(player1);
            player1Store = new Store();
            player1Inventory = new Inventory();
            day = new Day();
            player1Stand = new Stand();
            player1Customer = new Customer();
            weather = new Weather();
        }

        public void CalcWeeklyProfit(Player player)
        {
            weeklyProfit = player.CashOnHand - startingCash;
            UserInterface.WeeklyProfitPrompt(player, weeklyProfit);
        }

        public void RestartGame()
        {
            UserInterface.PlayAgainPrompt();
            string response = Console.ReadLine().Trim().ToLower();
            if (response == "yes")
            {
                RunGame();
            }
            else
            {
                UserInterface.ThanksForPlayingPrompt();
            }
        }

        public void PlayerWentBankrupt()
        {
            UserInterface.PlayerWentBankrupt();
            RestartGame();
        }

        public void EndOfGame(Player player)
        {
            if(weeklyProfit > 0)
            {
                UserInterface.PlayerWinsGamePrompt(player, weeklyProfit);
                RestartGame();
            }
            else
            {
                UserInterface.PlayerLosesGamePrompt(player, weeklyProfit);
                RestartGame();
            }
        }

        public void SimulateDayOfGame()
        {
            for (int i = 0; i < 30; i++)
            {
                if(player1Stand.cupsOfLemonadeLeftInPitcher <= 0)
                {
                    UserInterface.NotEnoughSuppliesPrompt(player1);
                    i = 30;
                    break;
                }
                else if(player1Inventory.IceCount >= 0 && player1Inventory.SugarCount >= 0 && player1Inventory.LemonCount >= 0 && player1Inventory.CupCount >= 0)
                {
                    player1Customer = new Customer();
                    player1Stand.DetermineIfCustomerBuys(player1Customer, weather, player1, player1Inventory, day);
                    if (player1Stand.cupsOfLemonadeLeftInPitcher <= 0)
                    {
                        player1Stand.PourLemonadePitcher(player1Inventory);
                    }
                }
                else
                {
                    UserInterface.NotEnoughSuppliesPrompt(player1);
                    break;
                }
            }
        }
        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
            for(dayNumber = 1 ; dayNumber <= numberOfDaysThreshold; dayNumber++)
            {
                UserInterface.DisplayDayNumber(dayNumber, numberOfDaysThreshold);
                UserInterface.DisplayWeatherIntroduction();
                UserInterface.DisplayForecast(weather);
                UserInterface.DisplayPriceOptions();
                UserInterface.DisplayPurchaseItems(player1, player1Inventory, ref day, player1Store);
                UserInterface.DisplayRecipeIntro();
                player1Stand.GenerateLemonadeRecipeAndPrice(player1Inventory);
                player1Stand.PourLemonadePitcher(player1Inventory);
                UserInterface.DisplayActualWeatherIntro();
                UserInterface.DisplayActualWeather(weather);
                UserInterface.StartSalesProcess();
                SimulateDayOfGame();
                UserInterface.NoCustomersRemaining();
                UserInterface.DisplayEndOfDaySummary(day, player1, player1Inventory);
                CalcWeeklyProfit(player1);
                day.ResetDailyData();
                if(player1.CashOnHand <= 0)
                {
                    PlayerWentBankrupt();
                }
                Console.Clear();
            }
            EndOfGame(player1);
        }

    }
}
