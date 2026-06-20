using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה__מערכת_כלי_רכב
{
    internal class Bicycle : Vehicle
    {
        public Bicycle(string lisensePlate, int speed) : base(lisensePlate, speed)
        {
            
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Bicycle is padding on the bike lane");
        }
    }
}
