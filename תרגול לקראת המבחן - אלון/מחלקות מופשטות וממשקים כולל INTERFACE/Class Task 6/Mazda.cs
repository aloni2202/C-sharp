using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_6
{
    internal class Mazda : Car
    {
        public string Owner { get; set; }
        public Mazda(int year, string model , string owner) : base(year, model)
        {
            Owner = owner;
        }
        public override string ToString()
        {
            return base.ToString() + $"The owner is {Owner}";
        }

        public override void FillGas()
        {
            Gas += 50;
            Console.WriteLine($"we filled 50 gas");
        }

        


    }
}
