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
        //need to create a global random variable
        //need to work on ensuring some variables are private and others are public so your security is up - PARTIALLY COMPLETE, CHECK WITH INSTRUCTOR
        //need to rewrite the game so it allows for multiplayer or AI
        //need to figure out how to incorporate the weather API

        //member variables
        public Player player1;
        public Player player2;
        public int numberOfDaysThreshold;
        public int dayNumber;
        public int startingCash;
        public Inventory player1Inventory;
        public Inventory player2Inventory;
        public Store store;
        public Day player1Day;
        public Day player2Day;
        public Stand player1Stand;
        public Stand player2Stand;
        public Customer player1Customers;
        public Customer player2Customers;
        public Weather player1Weather;
        public Weather player2Weather;
        //constructor
        public Game()
        {
            numberOfDaysThreshold = 7;
            startingCash = 100;
        }

        //member methods
        public int SetUpGame()
        {
            int numberOfPlayers = AskForNumberOfPlayers();
            Console.Clear();
            if(numberOfPlayers == 1)
            {
                OnePlayerGameSetup();
                return numberOfPlayers;
            }
            else
            {
                TwoPlayerGameSetup();
                return numberOfPlayers;
            }
        }

        public void OnePlayerGameSetup()
        {
            player1 = new Player();
            UserInterface.DisplayOnePlayerNameChoice(player1);
            store = new Store();
            player1Inventory = new Inventory();
            player1Day = new Day();
            player1Stand = new Stand();
            player1Customers = new Customer();
            player1Weather = new Weather();
        }

        public void TwoPlayerGameSetup()
        {
            player1 = new Player();
            player2 = new Player();
            UserInterface.DisplayFirstPlayerNameChoice(player1);
            UserInterface.DisplaySecondPlayerNameChoice(player2);
            store = new Store();
            player1Inventory = new Inventory();
            player2Inventory = new Inventory();
            player1Day = new Day();
            player2Day = new Day();
            player1Stand = new Stand();
            player2Stand = new Stand();
            player1Customers = new Customer();
            player2Customers = new Customer();
            player1Weather = new Weather();
            player2Weather = new Weather();
        }

        public int AskForNumberOfPlayers()
        {
            UserInterface.AskNumberOfPlayersPrompt();
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) || response < 1 || response > 2)
            {
                UserInterface.InvalidResponse();
                UserInterface.AskNumberOfPlayersPrompt();
            }
            return response;
        }


        public void RestartGame()
        {
            UserInterface.PlayAgainPrompt();
            string response = Console.ReadLine().Trim().ToLower();
            if (response == "yes")
            {
                Console.Clear();
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
            if (player.weeklyProfit > 0)
            {
                UserInterface.PlayerWinsGamePrompt(player, player.weeklyProfit);
                RestartGame();
            }
            else
            {
                UserInterface.PlayerLosesGamePrompt(player, player.weeklyProfit);
                RestartGame();
            }
        }


        public void SimulateDayOfGame(Player player, Stand stand, Inventory inventory, Day day, Customer customer, Weather weather)
        {
            for (int i = 0; i < 30; i++)
            {
                if(stand.cupsOfLemonadeLeftInPitcher <= 0)
                {
                    UserInterface.NotEnoughSuppliesPrompt(player);
                    i = 30;
                    break;
                }
                else if(inventory.IceCount >= 0 && inventory.SugarCount >= 0 && inventory.LemonCount >= 0 && inventory.CupCount >= 0)
                {
                    customer = new Customer();
                    stand.DetermineIfCustomerBuys(customer, weather, player, inventory, day);
                    if (stand.cupsOfLemonadeLeftInPitcher <= 0)
                    {
                        stand.PourLemonadePitcher(inventory);
                    }
                }
                else
                {
                    UserInterface.NotEnoughSuppliesPrompt(player);
                    break;
                }
            }
        }
        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            if (SetUpGame() == 1)
            {
                for (dayNumber = 1; dayNumber <= numberOfDaysThreshold; dayNumber++)
                {
                    UserInterface.DisplayDayNumber(dayNumber, numberOfDaysThreshold);
                    UserInterface.DisplayWeatherIntroduction();
                    UserInterface.DisplayForecast(player1Weather);
                    UserInterface.DisplayPriceOptions();
                    UserInterface.DisplayPurchaseItems(player1, player1Inventory, ref player1Day, store);
                    UserInterface.DisplayRecipeIntro();
                    player1Stand.GenerateLemonadeRecipeAndPrice(player1Inventory);
                    player1Stand.PourLemonadePitcher(player1Inventory);
                    UserInterface.DisplayActualWeatherIntro();
                    UserInterface.DisplayActualWeather(player1Weather);
                    UserInterface.StartSalesProcess();
                    SimulateDayOfGame(player1, player1Stand, player1Inventory, player1Day, player1Customers, player1Weather);
                    UserInterface.NoCustomersRemaining();
                    UserInterface.DisplayEndOfDaySummary(player1Day, player1, player1Inventory);
                    UserInterface.WeeklyProfitPrompt(player1, startingCash);
                    if (dayNumber == 7)
                    {
                        EndOfGame(player1);
                    }
                    player1Day.ResetDailyData();
                    if (player1.CashOnHand <= 0)
                    {
                        PlayerWentBankrupt();
                    }
                    Console.Clear();
                    
                }
            }
            else
            {
                UserInterface.MultiplayerIntro(player1);
                for (dayNumber = 1; dayNumber <= numberOfDaysThreshold; dayNumber++)
                {
                    UserInterface.PlayerTurnStart(player1);
                    UserInterface.DisplayDayNumber(dayNumber, numberOfDaysThreshold);
                    UserInterface.DisplayWeatherIntroduction();
                    UserInterface.DisplayForecast(player1Weather);
                    UserInterface.DisplayPriceOptions();
                    UserInterface.DisplayPurchaseItems(player1, player1Inventory, ref player1Day, store);
                    UserInterface.DisplayRecipeIntro();
                    player1Stand.GenerateLemonadeRecipeAndPrice(player1Inventory);
                    player1Stand.PourLemonadePitcher(player1Inventory);
                    //marks the end of player 1 seeing their weather forecast and making purchases, purchases, and setting price
                    UserInterface.PlayerTurnStart(player2);
                    UserInterface.DisplayDayNumber(dayNumber, numberOfDaysThreshold);
                    UserInterface.DisplayWeatherIntroduction();
                    UserInterface.DisplayForecast(player2Weather);
                    UserInterface.DisplayPriceOptions();
                    UserInterface.DisplayPurchaseItems(player2, player2Inventory, ref player2Day, store);
                    UserInterface.DisplayRecipeIntro();
                    player2Stand.GenerateLemonadeRecipeAndPrice(player2Inventory);
                    player2Stand.PourLemonadePitcher(player2Inventory);
                    //marks the end of player 2 seeing their weather forecase and making purchases, recipe, and setting price
                    UserInterface.PlayerTurnStart(player1);
                    UserInterface.DisplayActualWeatherIntro();
                    UserInterface.DisplayActualWeather(player1Weather);
                    UserInterface.StartSalesProcess();
                    SimulateDayOfGame(player1, player1Stand, player1Inventory, player1Day, player1Customers, player1Weather);
                    UserInterface.NoCustomersRemaining();
                    //marks the end of customers for player 1
                    UserInterface.PlayerTurnStart(player2);
                    UserInterface.DisplayActualWeatherIntro();
                    UserInterface.DisplayActualWeather(player2Weather);
                    UserInterface.StartSalesProcess();
                    SimulateDayOfGame(player2, player2Stand, player2Inventory, player2Day, player2Customers, player2Weather);
                    UserInterface.NoCustomersRemaining();
                    //marks the end of customers for player 2
                    UserInterface.PlayerTurnStart(player1);
                    UserInterface.DisplayEndOfDaySummary(player1Day, player1, player1Inventory);
                    UserInterface.WeeklyProfitPrompt(player1, startingCash);
                    //marks the end of day summary for player 1
                    UserInterface.PlayerTurnStart(player2);
                    UserInterface.DisplayEndOfDaySummary(player2Day, player2, player2Inventory);
                    UserInterface.WeeklyProfitPrompt(player2, startingCash);
                    Console.Clear();
                    UserInterface.MultiplayerEndOfDayIntro(dayNumber);
                    if(player1.weeklyProfit > player2.weeklyProfit)
                    {
                        UserInterface.MultiplayerEndOfDayPlayerWinning(player1, player2.weeklyProfit);
                    }
                    else if(player2.weeklyProfit > player1.weeklyProfit)
                    {
                        UserInterface.MultiplayerEndOfDayPlayerWinning(player2, player1.weeklyProfit);
                    }
                    else
                    {
                        UserInterface.MultiplayerEndOfDayTie(player1);
                    }
                    player1Day.ResetDailyData();
                    player2Day.ResetDailyData();
                    if (player1.CashOnHand <= 0)
                    {
                        PlayerWentBankrupt();
                    }
                    Console.Clear();
                    if (player2.CashOnHand <= 0)
                    {
                        PlayerWentBankrupt();
                    }
                }
                if(player1.weeklyProfit > player2.weeklyProfit)
                {
                    UserInterface.MultiplayerGameWinnerPrompt(player1, player1.weeklyProfit, player2.weeklyProfit);
                    RestartGame();
                }
                else if(player2.weeklyProfit > player1.weeklyProfit)
                {
                    UserInterface.MultiplayerGameWinnerPrompt(player2, player2.weeklyProfit, player1.weeklyProfit);
                    RestartGame();
                }
                else
                {
                    UserInterface.MultiplayerTieGamePrompt();
                    RestartGame();
                }
            }
        }

    }
}
