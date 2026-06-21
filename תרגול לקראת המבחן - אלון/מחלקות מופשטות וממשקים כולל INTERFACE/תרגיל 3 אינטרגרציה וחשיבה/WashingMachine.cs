using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_3_אינטרגרציה_וחשיבה
{
    internal class WashingMachine : Appliance
    {
        public WashingMachine(string brand, int price) : base(brand, price)
        {

        }

        public override void TurnOn()
        {
            Console.WriteLine($"The brand : {Brand} is turn on");
        }
    }
}
