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
        //Need to create the possiblity for the player to purchase items and increase their inventory
        //Need to have this result in their money also decreasing
        //It should also show that the inventory has increased within the stand so there is an interactive element
        //Need to work on ensuring this is part of the interface which shows the temperature
        //It also needs to show all relevant purchasing information
        //Generate the method for determining the profit within the game
        //the daily profit would be within the day class

        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
        public const int startingCash = 100;
        public int weeklyProfit;
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
        }

        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
            UserInterface.DisplayPriceOptions();
        }

    }
}
