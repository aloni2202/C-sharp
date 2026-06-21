using System;
using System.Collections.Generic;
using System.Text;

namespace מחלקות_מופשטות_וממשקים
{
    abstract class Appliance
    {
        public string Brand { get; set; }

        protected Appliance(string brand)
        {
            Brand = brand;
        }
        public abstract void TurnOn();
       
    }
}
