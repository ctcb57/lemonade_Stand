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
        //need to work on the starting cash variable to make sure it is actually used
        //need to put the inventory class in either the player or stand class
        //need to put the stand class in the player class
        //need to create a mechanism which forces the pitcher of lemonade to refill after it is depleted
        //need to input some set and get logic for the game to prevent the player from going into the negative
        //need to create a global random variable
        //need to work on making the math work in a logical way - consider switching all variables to doubles
        //need to work on user input verification measures to prevent user input errors
        //need to work on ensuring some variables are private and others are public so your security is up
        //need to rewrite the game so it allows for multiplayer or AI
        //need to figure out how to incorporate the weather API



        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
        public int dayNumber;
        public const int startingCash = 100;
        public int weeklyProfit;
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
            weeklyProfit = player1.cashOnHand - player1.startingCash;
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
                for (int i = 0; i < 20; i++)
                {
                    player1Customer = new Customer();
                    player1Stand.DetermineIfCustomerBuys(player1Customer, weather, player1, player1Inventory, day);
                }
                Console.ReadLine();
                Console.Clear();
                UserInterface.DisplayEndOfDaySummary();
                player1Inventory.DisplayItemCount();
                day.ShowDailySales(player1);
                day.ShowDailyProfit(player1Store, player1);
                CalcWeeklyProfit();
                day.ResetDailyData(player1Store);
                Console.Clear();
            }
            EndOfGame(player1);
        }

    }
}
