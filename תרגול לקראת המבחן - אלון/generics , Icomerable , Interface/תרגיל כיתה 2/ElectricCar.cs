using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_2
{
    internal class ElectricCar : IRechargeable
    {
        public void Recharge()
        {
            Console.WriteLine("Connecting to charge station ... ");
        }
    }
}
