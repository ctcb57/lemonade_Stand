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


    }
}
