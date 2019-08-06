using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
   public class Stand
    {
        //member variables
        public int priceOfLemonade;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int icePerPitcher;

        //constructor
        public Stand()
        {
        }
        //member methods
        public void CreateRecipe()
        {
            Console.WriteLine("How many lemons would you like to use per pitcher?");
            lemonsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar would you like to use per pitcher?");
            sugarPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice packs would you like to use per pitcher?");
            icePerPitcher = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public int SetLemondadePrice()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade?");
            priceOfLemonade = int.Parse(Console.ReadLine());
            return priceOfLemonade;
        }
    }
}
