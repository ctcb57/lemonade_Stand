using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_Stand
{
    public class Customer
    {
        //strategy for the customers
        //create a list of 10 customers
        //have the list go through a foreach loop when they are interacting with the price set, the temp, and rain
        //ensure it is verifying if the customer is buying the lemonade or not
        //when they buy the lemonade, ensure it is increasing the cashOnHand for the player
        //also ensure it shows the profit margin for the player within the game class
        //ultimately it will show the daily profit and then it will show the weekly profit
        //member variables
        public int idNumber;
        public int temperaturePreference;
        public bool precipitationPreference;
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
            temperaturePreference = random.Next(50, 101);
            pricePreference = random.Next(0, 5);
            int number = random.Next(0, 2);
            if(number == 0)
            {
                precipitationPreference = true;
            }
            else
            {
                precipitationPreference = false;
            }
        }
    }
}
