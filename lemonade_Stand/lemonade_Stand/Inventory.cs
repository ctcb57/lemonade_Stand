using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Inventory
    {
        //member variables

        private int lemonCount;
        private int sugarCount;
        private int cupCount;
        private int iceCount;

        public int LemonCount
        {
            get
            {
                return lemonCount;
            }
            set
            {
                //lemonCount = value < 0 ? 0 : value;
                if (value <= 0)
                {
                    lemonCount = 0;
                }
                else
                {
                    lemonCount = value;
                }
            }
        }

        public int SugarCount
        {
            get
            {
                return sugarCount;
            }
            set
            {
                //sugarCount = value < 0 ? 0 : value;
                if (value <= 0)
                {
                    sugarCount = 0;
                }
                else
                {
                    sugarCount = value;
                }
            }
        }

        public int CupCount
        {
            get
            {
                return cupCount;
            }
            set
            {
                //cupCount = value < 0 ? 0 : value;
                if (value <= 0)
                {
                    cupCount = 0;
                }
                else
                {
                    cupCount = value;
                }
            }
        }

        public int IceCount
        {
            get
            {
                return iceCount;
            }
            set
            {
                //iceCount = value < 0 ? 0 : value;
                if (value <= 0)
                {
                    iceCount = 0;
                }
                else
                {
                    iceCount = value;
                }
            }
        }


        //constructor
        public Inventory()
        {

        }
        //member variables
        public void DisplayItemCount()
        {
            Console.WriteLine("You currently have " + lemonCount + " lemons.");
            Console.WriteLine("You currently have " + sugarCount + " cups of sugar.");
            Console.WriteLine("You currently have " + cupCount + " cups.");
            Console.WriteLine("You currently have " + iceCount + " packs of ice");
            Console.ReadLine();
            //remove this at the time of turning in the project or putting everything together
        }

    }
}
