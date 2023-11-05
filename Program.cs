using ATM;
using System;
using System.Collections.Generic;
using System.Linq;

public class ATMApp
{
    public static void Main(string[] args)
    {
        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("123123123123", 1111, "Niklas", "Sjödin", 750.00));
        cardHolders.Add(new CardHolder("6666", 1111, "Linda", "Ohlsson", 1750.00));

        Console.WriteLine("Welcome to myATM!");
        Console.WriteLine("Please enter your debit card: ");
        string debitCardNum = "";
        CardHolder currentUser = null;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recognized. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again.");
            }
        }

        Console.WriteLine("Please enter your PIN: ");
        string pinInput = "";
        while (true)
        {
            try
            {
                ConsoleKeyInfo keyInfo;
                string pin = "";
                do
                {
                    keyInfo = Console.ReadKey(true); // Read a key without displaying it
                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                    {
                        pin += keyInfo.KeyChar;
                        Console.Write("*"); // Display a star for each character
                    }
                    else
                    {
                        if (keyInfo.Key == ConsoleKey.Backspace && pin.Length > 0)
                        {
                            pin = pin.Substring(0, pin.Length - 1);
                            Console.Write("\b \b"); // Clear the last character and move the cursor back
                        }
                    }
                }
                while (keyInfo.Key != ConsoleKey.Enter);

                int userPin = int.Parse(pin);
                if (currentUser.Pin == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect pin. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("\nIncorrect pin. Please try again.");
            }
        }

        Console.WriteLine("\nWelcome " + currentUser.FirstName);
        int option = 0;
        do
        {
            Console.Clear(); // Clear the screen
            Console.WriteLine("Please choose one from one of the following options..");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            try
            {
                option = int.Parse(Console.ReadLine());
                if (option >= 1 && option <= 4)
                {
                    // Valid option (1-4)
                    if (option == 1)
                    {
                        Deposit.ShowDeposit(currentUser);
                    }
                    else if (option == 2)
                    {
                        Withdraw.ShowWithdraw(currentUser);
                    }
                    else if (option == 3)
                    {
                        ShowBalance.Show(currentUser);
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select a valid option (1-4).");
                }
                Console.WriteLine("Press Enter to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                Console.WriteLine("Press Enter to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
        }
        while (option != 4);
        Console.WriteLine("Thank you. Have a nice day.");
    }
}