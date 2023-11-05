using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Deposit
    {
        public static void ShowDeposit(CardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine("Deposit");
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = 0;
            try
            {
                deposit = double.Parse(Console.ReadLine());
                currentUser.Balance += deposit;
                Console.WriteLine("You have deposited: $" + deposit);
                Console.WriteLine("Your new balance is: $" + currentUser.Balance);
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }
        }
    }
}
