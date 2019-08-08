using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Player
    {
        //member variables
        public string name;
        private int cashOnHand;

        public int CashOnHand
        {
            get
            {
                return cashOnHand;
            }
            set
            {
                if (value <= 0)
                {
                    cashOnHand = 0;
                }
                else
                {
                    cashOnHand = value;
                }
            }
        }

        //constructor
        public Player()
        {
            cashOnHand = 100;
        }
        //member methods
        public void ChooseName()
        {
            name = Console.ReadLine().Trim();
            Console.Clear();
        }


    }
}
