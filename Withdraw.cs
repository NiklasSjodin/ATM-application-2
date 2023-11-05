using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Withdraw
    {
        public static void ShowWithdraw(CardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine("Withdraw");
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = 0;
            try
            {
                withdrawal = double.Parse(Console.ReadLine());

                if (currentUser.Balance < withdrawal)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    currentUser.Balance -= withdrawal;
                    Console.WriteLine("You have withdrawn: $" + withdrawal);
                    Console.WriteLine("Your current balance is: $" + currentUser.Balance);
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }
        }
    }
}
