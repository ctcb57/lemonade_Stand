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
        //need to put the inventory class in either the player or stand class
        //need to put the stand class in the player class
        //need to input some set and get logic for the game to prevent the player from going into the negative - DON'T NEED YET
        //need to create a global random variable
        //Need to ensure that all of of the console.writelines are located within the user interface
        //need to work on making the math work in a logical way - consider switching all variables to doubles
        //need to work on user input verification measures to prevent user input errors
        //need to work on ensuring some variables are private and others are public so your security is up
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
            player1.ChooseName();
            player1Store = new Store();
            player1Inventory = new Inventory();
            day = new Day();
            player1Stand = new Stand();
            player1Customer = new Customer();
            weather = new Weather();
        }

        public void CalcWeeklyProfit()
        {
            weeklyProfit = player1.cashOnHand - startingCash;
            if (weeklyProfit > 0)
            {
                Console.WriteLine(player1.name + " has earned $" + weeklyProfit + " total this week.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player1.name + " has lost $" + weeklyProfit + " total this week.");
                Console.ReadLine();
            }
        }

        public void RestartGame()
        {
            Console.WriteLine("Would you like to play again?");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing! Press enter to exit.");
                Console.ReadLine();
            }
        }

        public void PlayerWentBankrupt()
        {
            Console.WriteLine("You do not have any money left!");
            Console.WriteLine("You lost the game!");
            RestartGame();
        }

        public void EndOfGame(Player player)
        {
            if(weeklyProfit > 0)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("  ");
                Console.WriteLine(player.name + " has made a profit for the week!");
                Console.WriteLine(player.name + "'s total profit was $" + weeklyProfit + ".");
                Console.ReadLine();
                RestartGame();
            }
            else
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("  ");
                Console.WriteLine(player.name + " did not make a profit for the week.");
                Console.WriteLine(player.name + "'s total loss was $" + weeklyProfit + ".");
                Console.WriteLine(player.name + " loses the game!");
                Console.ReadLine();
                RestartGame();
            }
        }

        public void SimulateDayOfGame()
        {
            for (int i = 0; i < 30; i++)
            {
                if (player1Inventory.iceCount > 0 && player1Inventory.sugarCount > 0 && player1Inventory.lemonCount > 0 && player1Inventory.cupCount > 0)
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
                    Console.WriteLine(player1.name + " doesn't have enough supplies to continue making lemonade.");
                    Console.WriteLine(player1.name + "is unable to sell anymore lemonade.  The day will now end.");
                    Console.ReadLine();
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
                Console.WriteLine("Today is day number " + dayNumber + " of " + numberOfDaysThreshold);
                UserInterface.DisplayWeatherIntroduction();
                day.DisplayDailyWeatherForecast(weather);
                Console.Clear();
                UserInterface.DisplayPriceOptions();
                player1Store.PurchaseItems(player1Inventory, player1);
                UserInterface.DisplayRecipeIntro();
                player1Stand.CreateRecipe();
                player1Stand.SetLemondadePrice();
                player1Stand.PourLemonadePitcher(player1Inventory);
                UserInterface.DisplayActualWeather();
                day.DisplayDailyActualWeather(weather);
                UserInterface.StartSalesProcess();
                SimulateDayOfGame();
                Console.ReadLine();
                Console.Clear();
                UserInterface.DisplayEndOfDaySummary();
                player1Inventory.DisplayItemCount();
                day.ShowDailySales(player1);
                day.ShowDailyProfit(player1Store, player1);
                CalcWeeklyProfit();
                day.ResetDailyData(player1Store);
                if(player1.cashOnHand <= 0)
                {
                    PlayerWentBankrupt();
                }
                Console.Clear();
            }
            EndOfGame(player1);
        }

    }
}
