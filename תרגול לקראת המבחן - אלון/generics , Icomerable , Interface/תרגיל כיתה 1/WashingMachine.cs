using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_1
{
    internal class WashingMachine : Aplliance
    {
        public WashingMachine(string b) : base(b)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine($"The washing mashine of : {Brand} is turn on");
        }
    }
}
