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

        //member variables
        public Player player1;
        public int numberOfDaysThreshold;
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

        public void PurchaseItems()
        {
            double lemonsPurchased = player1.PurchaseLemons();

        }

        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
            player1.DisplayCashOnHand();
            UserInterface.DisplayPriceOptions();
        }

    }
}
