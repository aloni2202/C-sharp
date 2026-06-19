using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה__1
{
    internal class Vehicle
    {
        
        protected string Model;
        protected int Year;

        public Vehicle(string model , int year)
        {
            Model = model;
            Year = year;
        }
        public void PrintDetails()
        {
            Console.WriteLine("The car details : ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{Model}\n{Year}");
        }
    }
}
