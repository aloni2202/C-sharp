using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_2____ניהול_מערך_כלי_טיס
{
    internal class PassengersPlane : Aircraft
    {
        int passengersCount;
        public PassengersPlane(int a, string f, int passengersCount) : base(a, f)
        {
            this.passengersCount = passengersCount;
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"The flight number: {FlightNumber}\nis on hight {Altitude}\nThe passengers count : {passengersCount}");
        }
    }
}
