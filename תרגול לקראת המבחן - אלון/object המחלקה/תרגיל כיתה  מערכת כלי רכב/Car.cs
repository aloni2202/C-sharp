using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה__מערכת_כלי_רכב
{
    internal class Car : Vehicle
    {
        public Car(string lisensePlate , int speed):base(lisensePlate , speed)
        {
            
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Car is driving on the road");
        }
        public void TurnOnAirConditioner()
        {
            Console.WriteLine($"Air conditioner is turned on {LisensePlate}" );
        }
    }
}
