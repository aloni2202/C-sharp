using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_1
{
    abstract class Aplliance
    {
        public string  Brand { get; set; }

        protected Aplliance(string b)
        {
            Brand = b;
        }
        public abstract void TurnOn();

    }
}
