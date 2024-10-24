using ContaBancaria.Entities;
using ContaBancaria.Entities.Exeptions;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberCount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Account account = new Account(numberCount, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for Withdraw: ");
                double amountForWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amountForWithdraw);
                account.NewBalance();
                
            }
            catch (DomainException error)
            {
                Console.WriteLine("Withdraw error: " + error.Message);
            }

            
        }
    }
}