using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    class Customer
    {
        //member variables
        public string idNumber;
        public int temperatuePreference;
        public bool precipitationPreference;
        public double pricePreference;

        //constructor
        public Customer(string idNumber, int temperaturePreference, bool precipitationPreference, double pricePreference)
        {
            Customer first = new Customer("001", 70, true, 0.20);
        }
        //member methods
    }
}
