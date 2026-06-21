using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_6
{
    internal class Audi : Car
    {
        public int MaxSpees { get; set; }
        public Audi(int year, string model , int maxSpeed) : base(year, model)
        {
            MaxSpees = maxSpeed;
        }

        public override string ToString()
        {
            return base.ToString() + $"The max speed : {MaxSpees}";
        }

        public override void FillGas()
        {
            Gas += 60;
            Console.WriteLine("filled 60 gas");
        }
    }
}
