using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Q2
{
    internal class PassengerPlane : Aircraft
    {
        public int passengersCount;
        public PassengerPlane(int altitude, string flightNumber, int passengersCount) : base(altitude, flightNumber)
        {
            this.passengersCount = passengersCount;
        }
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($" , The number of passengers is : {passengersCount}");
            Console.WriteLine("------------------------------------------------------------------------------------");

        }
    }
}
