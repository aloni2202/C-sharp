using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_1_מבחן_לדגומא
{
    abstract class RandomNumber
    {
        public int Number { get; set; }

        protected RandomNumber(int number)
        {
            Number = number;
        }

        public  RandomNumber()
        {
            Random rnd = new Random();
           Number = rnd.Next(1,100);
        }
        public override string ToString()
        {
            return $" Number : {Number.ToString()} , ";
        }
    }
}
