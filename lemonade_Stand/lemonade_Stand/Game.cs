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
        // - Create the rules for the game and a display rules method in the UI
        // - Create user name entry method
        // - Create all classes along with parent and child relationships
        // - Create member variables for all classes
        // - Create initial member methods for appropriate classes
        // - Create UML with child classes
        // - Start to build the initial values of all member variables
        // - Create the game play

        //member variables
        private Player player1;
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

        
        public void RunGame()
        {
            UserInterface.DisplayRules();
            SetUpGame();
        }

    }
}
