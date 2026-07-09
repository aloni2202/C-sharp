using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3
{
    abstract class Aplliance : IComparable<Aplliance>
    {
        public string Brand { get; set; }
        public int Price { get; set; }

        protected Aplliance(string b, int p)
        {
            Brand = b;
            Price = p;
        }
        public abstract void TurnOn();

        public int CompareTo(Aplliance? other)
        {
            Aplliance aplliance = other as Aplliance;
            if (this.Price > other.Price) return 1;
            if (this.Price < other.Price) return -1;
            return 0;
        }
    }
}
