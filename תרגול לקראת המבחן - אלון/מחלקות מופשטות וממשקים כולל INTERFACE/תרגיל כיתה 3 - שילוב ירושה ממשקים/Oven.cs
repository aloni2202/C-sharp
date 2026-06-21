using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3___שילוב_ירושה_ממשקים
{
    internal class Oven : Appliance
    {
        public Oven(string brand , int price) : base(brand , price)
        {

        }

        public override void TurnOn()
        {
            Console.WriteLine($"The brand : {Brand} is turn on");
        }
    }
}
