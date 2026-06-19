using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה__1
{
    internal class Car : Vehicle
    {
        public int numOfDoors;

        public Car(string Model, int Year, int num) : base(Model, Year)
        {
            numOfDoors = num;
        }

        public new void PrintDetails()
        {
            base.PrintDetails();
            Console.Write($"{numOfDoors}\n");
        }
    }
}
