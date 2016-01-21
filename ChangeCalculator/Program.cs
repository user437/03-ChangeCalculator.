using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {


        static void Main(string[] args)
        {

            //ask the customer to enter the cost
            Console.WriteLine("Item cost: ");

            string cost = Console.ReadLine();

            decimal totalCost = decimal.Parse(cost);



            Console.WriteLine("Money from customer: ");

            string money = Console.ReadLine();

            decimal receivedMoney = decimal.Parse(money);

            decimal change = receivedMoney - totalCost;


            decimal quarters = change / 0.25m;
            decimal myQuarters = Math.Floor(quarters);

            decimal dimes = (change % 0.25m) / 0.1m;
            decimal myDimes = Math.Floor(dimes);

            decimal nickelsAnyone = ((change % 0.25m) % 0.1m) / 0.05m;
            decimal myNickels = Math.Floor(nickelsAnyone);

            decimal pennies = (((change % 0.25m) % 0.1m) % 0.05m) / 0.01m;
            decimal myPennies = Math.Floor(pennies);



            Console.WriteLine("Amount to returned: " + change);

            Console.WriteLine("Change to returned: ");

            Console.WriteLine("Quarters: " + myQuarters);

            Console.WriteLine("Dimes: " + myDimes);

            Console.WriteLine("Nickels: " + myNickels);

            Console.WriteLine("Pennies: " + myPennies);


            Console.ReadLine();


        }
    }
}