using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class VipAccount : Account
    {
        public VipAccount(int accountNumber, double balance) : base(accountNumber, balance)
        {
            
        }
        public override void Withdraw(double amount)
        {
            const double limitVip = -5000;
            if ((balance - amount) >= limitVip)
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
