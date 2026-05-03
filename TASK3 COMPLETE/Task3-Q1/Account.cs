using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Account
    {
        protected int accountNumber;
        protected double balance;

        public Account(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine($"Your bank balance is : {balance}");
            }
            else
            {
                Console.WriteLine("Not enough money :(");
            }
        }

    }
}