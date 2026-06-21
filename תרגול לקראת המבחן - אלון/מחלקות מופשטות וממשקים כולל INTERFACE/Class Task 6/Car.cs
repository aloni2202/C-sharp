using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_6
{
    abstract class Car : IComparable, IDrive
    {
        public int Year { get; set; }
        public string Model { get; set; }

        public int Gas { get; set; }
        public int Kilometer { get; set; }

        public static bool sortedByGas;

        protected Car(int year, string model)
        {
            Year = year;
            Model = model;
            Gas = 100;
        }

        public void Drive(int km)
        {
            if (km <= Gas)
            {
                Kilometer += km;
                Gas -= km;
                Console.WriteLine($"The total gas that drove by {GetType().Name} {Model} is : {Kilometer}");
            }
            else
            {
                Console.WriteLine("Not enough gas to drive that distance");
            }
        }

        public override string ToString()
        {
            return $"car : {GetType().Name} Model : {Model} of year : {Year} drove total : {Kilometer} km and the gas left is : {Gas} ";
        }

        public abstract void FillGas();

        public int CompareTo(object? obj)
        {
            Car c = obj as Car;
            if (c == null)
            
                throw new ArgumentException("The object is Not a Car");
            
            if (sortedByGas)
            
                return Gas.CompareTo(c.Gas);
                return Model.CompareTo(c.Model);
        }
    }
}
