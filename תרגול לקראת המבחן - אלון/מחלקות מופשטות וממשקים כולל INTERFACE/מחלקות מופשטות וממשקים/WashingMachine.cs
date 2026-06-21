using System;
using System.Collections.Generic;
using System.Text;

namespace מחלקות_מופשטות_וממשקים
{
    internal class WashingMachine : Appliance
    {
        public WashingMachine(string brand) : base(brand)
        {

        }

        public override void TurnOn()
        {
            Console.WriteLine($"The brand : {Brand} is turn on");
        }
    }
}
