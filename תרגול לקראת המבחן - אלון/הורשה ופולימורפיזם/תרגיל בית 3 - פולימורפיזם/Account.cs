using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית_3___פולימורפיזם
{
    internal class Account
    {
        protected int accountNumber;
        protected double balance;
        protected double Amount;

        public Account(int accountNum, double B)
        {
            accountNumber = accountNum;
            balance = B;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance && (balance - amount) >= 0)
            {
                balance -= amount;
                Console.WriteLine(balance);
            }
            else
            {
                Console.WriteLine("Not enogth money .. ");
            }
        }
    }
}
