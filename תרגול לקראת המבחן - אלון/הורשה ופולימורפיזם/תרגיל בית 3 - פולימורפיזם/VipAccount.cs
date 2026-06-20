using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית_3___פולימורפיזם
{
    internal class VipAccount : Account
    {
        const double limit = -5000;
        public VipAccount(int accountNum, double B) : base(accountNum, B)
        {
        }
        public override void Withdraw(double amount)
        {

            if ( (balance - amount) >= limit)
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
