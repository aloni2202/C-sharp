using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3___שילוב_ירושה_ממשקים
{
    abstract class Appliance : IComparable
    {
        public string Brand { get; set; }

        public int Price { get; set; }

        protected Appliance(string brand , int price)
        {
            Brand = brand;
            Price = price;
        }
        public abstract void TurnOn();

        public int CompareTo(object obj)
        {
            Appliance other = (Appliance)obj;

            if (this.Price < other.Price)
            {
                return -1;
            }
            if (this.Price > other.Price)
            {
                return 1;
            }
            return 0;
}
}
}
