using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_1
{
    internal class Oven : Aplliance
    {
        public Oven(string b) : base(b)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine($"The oven of : {Brand} is turn On ");
        }
    }
}
