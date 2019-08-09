using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    static class UserInterface
    {
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Here are the rules to the game:");
            Console.WriteLine("  ");
            Console.WriteLine("You will start by purchasing any supplies you believe are necessary given the forecasted weather conditions.");
            Console.WriteLine("After purchasing supplies, you will create your lemonade recipe and set your price.");
            Console.WriteLine("You will start the day which will simulate how much lemonade you sold.");
            Console.WriteLine("You must survive for seven days.");
            Console.WriteLine("   ");
            Console.WriteLine("Things to keep in mind:");
            Console.WriteLine("Customer demand will vary depending on the weather and your price.");
            Console.WriteLine("Ensure you have enough supplies to make it through the day.");
            Console.WriteLine("You will encounter anywhere between 25 and 50 customers each day, so supplies will be crucial");
            Console.WriteLine("If you don't keep a positive cash balance, you will go bankrupt and lose the game");
            Console.WriteLine("   ");
            Console.WriteLine("Press ENTER to begin your game");
            Console.ReadLine();
            Console.Clear();
        }

        public static void AskNumberOfPlayersPrompt()
        {
            Console.WriteLine("How many players would you like? Please select 1 or 2.");
        }

        public static void InvalidResponse()
        {
            Console.WriteLine("That's an invalid response.");
        }

        public static void DisplayPriceOptions()
        {
            Console.WriteLine("Welcome to the Store!");
            Console.WriteLine("  ");
            Console.WriteLine("Here is the list of items and their prices:");
            Console.WriteLine("Cups: $1 per cup");
            Console.WriteLine("Lemons: $3 per lemon");
            Console.WriteLine("Sugar: $2 per cup of sugar");
            Console.WriteLine("Ice: $1 per ice pack");
            Console.WriteLine("   ");
            Console.WriteLine("Please indicate how much of each item you would like to purchase:");
            Console.WriteLine("   ");
        }

        public static void DisplayOnePlayerNameChoice(Player player)
        {
            Console.WriteLine("Choose your player's name:");
            player.ChooseName();
        }

        public static void DisplayFirstPlayerNameChoice(Player player)
        {
            Console.WriteLine("Player 1, choose your name:");
            player.ChooseName();
        }

        public static void MultiplayerIntro(Player player)
        {
            Console.WriteLine(player.name + " will go first.");
            Console.WriteLine("Each player start by taking turns seeing their weather forecast, purchasing items, and setting recipes and prices");
            Console.WriteLine("Next, each player will simulate their day");
            Console.WriteLine("At the conclusion of each day, it will display how each player is doing");
            Console.WriteLine("At the end of the game, the player who earned the largest profit margin will win");
            Console.WriteLine("Press enter to begin the game");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PlayerTurnStart(Player player)
        {
            Console.WriteLine("It is " + player.name + "'s turn.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplaySecondPlayerNameChoice(Player player)
        {
            Console.WriteLine("Player 2, choose your name:");
            player.ChooseName();
        }
        public static void DisplayDayNumber(int dayNumber, int numberOfDaysThreshold)
        {
            Console.WriteLine("Today is day " + dayNumber + " of " + numberOfDaysThreshold);
        }

        public static void DisplayWeatherIntroduction()
        {
            Console.WriteLine("Weather will influence demand of your product.  Higher temperatures result in higher demand.");
            Console.WriteLine("Here is the forecasted weather for today:");
            Console.ReadLine();
        }

        public static void DisplayForecast(Weather weather)
        {
            Console.WriteLine("Projected Temperature is: " + weather.ForecastTemperature() + " degrees");
            if(weather.ForecastPrecipitation() == true)
            {
                Console.WriteLine("It is projected to rain");
            }
            else
            {
                Console.WriteLine("There is no rain in the forecast");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayItemCount(Inventory inventory)
        {
            Console.WriteLine("You currently have " + inventory.LemonCount + " lemons.");
            Console.WriteLine("You currently have " + inventory.SugarCount + " cups of sugar.");
            Console.WriteLine("You currently have " + inventory.CupCount + " cups.");
            Console.WriteLine("You currently have " + inventory.IceCount + " packs of ice");
            Console.ReadLine();
        }

        public static void DisplayCashOnHand(Player player)
        {
            Console.WriteLine(player.name + " 's current cash on hand is: " + player.CashOnHand);
            Console.ReadLine();
        }

        public static void PurchaseLemonsPrompt()
        {
            Console.WriteLine("How many lemons would you like to purhcase?");
        }
        public static void InvalidLemonResponse()
        {
            Console.WriteLine("You entered an invalid amount.");
            Console.WriteLine("How many lemons would you like to purchase?");
        }

        public static void PurchaseIcePrompt()
        {
            Console.WriteLine("How many ice packs would you like to purhcase?");
        }
        public static void InvalidIceResponse()
        {
            Console.WriteLine("You entered an invalid amount.");
            Console.WriteLine("How many ice packs would you like to purchase?");
        }

        public static void PurchaseSugarPrompt()
        {
            Console.WriteLine("How many cups of sugar would you like to purhcase?");
        }
        public static void InvalidSugarResponse()
        {
            Console.WriteLine("You entered an invalid amount.");
            Console.WriteLine("How many cups of sugar would you like to purchase?");
        }

        public static void PurchaseCupsPrompt()
        {
            Console.WriteLine("How many cups would you like to purhcase?");
        }
        public static void InvalidCupsResponse()
        {
            Console.WriteLine("You entered an invalid amount.");
            Console.WriteLine("How many cups would you like to purchase?");
        }

        public static void DisplayPurchaseItems(Player player, Inventory inventory, ref Day day, Store store)
        {
            DisplayItemCount(inventory);
            store.PurchaseItems(player, inventory, day);
            DisplayItemCount(inventory);
            Console.WriteLine(player.name + " spent $" + day.totalPurchase + " on supplies today.");
            Console.ReadLine();
            Console.Clear();
        }


        public static void DisplayRecipeIntro()
        {
            Console.WriteLine("Now you create your lemonade recipe.");
            Console.WriteLine("You will decide how many lemons, cups of sugar, and ice packs go into each pitcher");
            Console.WriteLine("Each pitcher will generate 10 cups of lemonade");
            Console.ReadLine();
        }

        public static void LemonRecipePrompt()
        {
            Console.WriteLine("How many lemons would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void InvalidLemonRecipeEntry()
        {
            Console.WriteLine("That's an invalid response");
            Console.WriteLine("How many lemons would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void SugarRecipePrompt()
        {
            Console.WriteLine("How many cups of sugar would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void InvalidSugarRecipeEntry()
        {
            Console.WriteLine("That's an invalid response");
            Console.WriteLine("How many cups of sugar would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void IceRecipePrompt()
        {
            Console.WriteLine("How many ice packs would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void InvalidIceRecipeEntry()
        {
            Console.WriteLine("That's an invalid response");
            Console.WriteLine("How many ice packs would you like to use per pitcher? You must use more than zero and less than you currently have");
        }

        public static void SetLemonadePricePrompt()
        {
            Console.WriteLine("  ");
            Console.WriteLine("How much would you like to charge per cup of lemonade? Set the price between $1 and $10");
        }

        public static void InvalidLemonadePriceEntry()
        {
            Console.WriteLine("That's an invalid response");
            Console.WriteLine(" ");
            Console.WriteLine("How much would you like to charge per cup of lemonade?  Set the price between $1 and $10");
        }

        public static void InvalidPourLemonadeResponse()
        {
            Console.WriteLine("You do not have enough inventory to pour another pitcher of lemonade");
            Console.WriteLine("You will not be able to sell to another customer today.");
            Console.ReadLine();
        }

        public static void DisplayActualWeatherIntro()
        {
            Console.WriteLine("The forecasted weather has changed slightly");
            Console.WriteLine("The actual weather for today will be:");
            Console.ReadLine();
        }

        public static void DisplayActualWeather(Weather weather)
        {
            Console.WriteLine("The temperature will be: " + weather.GenerateActualTemperature() + " degrees");
            Console.WriteLine("  ");
            if(weather.GenerateActualPrecipitation() == true)
            {
                Console.WriteLine("It will rain today.");
            }
            else
            {
                Console.WriteLine("It will not rain today.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void StartSalesProcess()
        {
            Console.Clear();
            Console.WriteLine("You're open for business for the day!");
            Console.WriteLine("Your customers are starting to visit the stand");
            Console.WriteLine("The customers decisions will be listed below:");
            Console.WriteLine("  ");
            Console.ReadLine();
        }

        public static void NotEnoughSuppliesPrompt(Player player)
        {
            Console.WriteLine(player.name + " doesn't have enough supplies to continue making lemonade.");
            Console.WriteLine(player.name + "is unable to sell anymore lemonade.  The day will now end.");
            Console.ReadLine();
        }

        public static void CustomerPurchased(Customer customer, Player player)
        {
            Console.WriteLine("Customer " + customer.idNumber + " purchased lemonade");
            Console.WriteLine("You now have " + player.CashOnHand + " dollars of cash on hand");
            Console.ReadLine();
        }

        public static void CustomerDidNotPurchase(Customer customer)
        {
            Console.WriteLine("Customer " + customer.idNumber + " didn't purchase lemonade");
            Console.ReadLine();
        }

        public static void NoCustomersRemaining()
        {
            Console.WriteLine("No customers remaining for the day!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayEndOfDaySummary(Day day, Player player, Inventory inventory)
        {
            Console.WriteLine("That marks the end of the day!");
            Console.WriteLine("Here is how today went:");
            Console.WriteLine("  ");
            Console.WriteLine(player.name + " currenly has the following inventory:");
            DisplayItemCount(inventory);
            DisplayCashOnHand(player);
            Console.WriteLine(player.name + " earned $" + day.dailySales + " in sales today.");
            Console.ReadLine();
            if(day.ShowDailyProfit() > 0)
            {
                Console.WriteLine(player.name + " had a total profit of $" + day.dailyProfit + " today.");
            }
            else
            {
                Console.WriteLine(player.name + " had a total loss of $" + day.dailyProfit + " today.");
            }
            Console.ReadLine();
        }

        public static void WeeklyProfitPrompt(Player player, int startingCash)
        {
            if (player.CalculateWeeklyProfit(startingCash) > 0)
            {
                Console.WriteLine(player.name + " has profited $" + player.weeklyProfit + " total this week.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player.name + " has a profit loss of $" + player.weeklyProfit + " total this week.");
                Console.ReadLine();
            }
            Console.Clear();
        }

        public static void MultiplayerEndOfDayIntro(int dayNumber)
        {
            Console.WriteLine("That marks the end of day " + dayNumber + ".");
            Console.WriteLine(" ");
        }

        public static void MultiplayerEndOfDayPlayerWinning(Player player, int player2Profit)
        {
            Console.WriteLine(player.name + " is currently winning");
            Console.WriteLine(player.name + " has a profit lead of $" + (player.weeklyProfit - player2Profit) + ".");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MultiplayerEndOfDayTie(Player player)
        {
            Console.WriteLine("The game is currently tied");
            Console.WriteLine("Both players have earned $" + player.weeklyProfit);
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PlayerWentBankrupt()
        {
            Console.WriteLine("You do not have any money left!");
            Console.WriteLine("You lost the game!");
        }

        public static void PlayerWinsGamePrompt(Player player, int weeklyProfit)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("  ");
            Console.WriteLine(player.name + " has made a profit for the week!");
            Console.WriteLine(player.name + "'s total profit was $" + weeklyProfit + ".");
            Console.ReadLine();
        }

        public static void PlayerLosesGamePrompt(Player player, int weeklyProfit)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("  ");
            Console.WriteLine(player.name + " did not make a profit for the week.");
            Console.WriteLine(player.name + "'s total loss was $" + weeklyProfit + ".");
            Console.WriteLine(player.name + " loses the game!");
            Console.ReadLine();
        }

        public static void MultiplayerGameWinnerPrompt(Player player, int weeklyProfit1, int weeklyProfit2)
        {
            Console.WriteLine(player.name + " has won!");
            Console.WriteLine("They won by a margin of $" + (weeklyProfit1 - weeklyProfit2) + ".");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MultiplayerTieGamePrompt()
        {
            Console.WriteLine("The game has resulted in a tie!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
        }



        public static void PlayAgainPrompt()
        {
            Console.WriteLine("Would you like to play again? Type yes or no");
        }

        public static void ThanksForPlayingPrompt()
        {
            Console.WriteLine("Thanks for playing! Press enter to exit.");
            Console.ReadLine();
        }

    }
}
