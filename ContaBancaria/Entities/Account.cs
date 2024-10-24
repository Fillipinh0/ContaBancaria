using ContaBancaria.Entities.Exeptions;
using System.Globalization;
using System;


namespace ContaBancaria.Entities
{
    internal class Account
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get ; set; }
        private double WithdrawLimit { get; set; }
        public Account() { }
        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void NewBalance()
        {
            Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enougth balance");
            }

            Balance -= amount;
        }

    }
}
