using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ShowBalance
    {
        public static void Show(CardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine("Show Balance");
            Console.WriteLine("Current balance: $" + currentUser.Balance);
        }
    }
}
