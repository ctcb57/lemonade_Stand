using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Customer
    {
        //member variables
        public int idNumber;
        public int temperaturePreference;
        public int pricePreference;

        //constructor
        public Customer()
        {
            GenerateCustomerPreferences();
        }
        //member methods
        public void GenerateCustomerPreferences()
        {
            Random random = new Random();
            idNumber = random.Next(100);
            temperaturePreference = random.Next(50, 83);
            pricePreference = random.Next(0, 9);
        }
    }
}
