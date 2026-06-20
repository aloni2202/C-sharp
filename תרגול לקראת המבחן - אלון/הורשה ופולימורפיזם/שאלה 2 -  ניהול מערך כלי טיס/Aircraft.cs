using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_2____ניהול_מערך_כלי_טיס
{
    internal class Aircraft
    {
        public int Altitude { get; set; }
        public string FlightNumber { get; set; }

        public Aircraft(int a , string f)
        {
            Altitude = a;
            FlightNumber = f;
        }

        public virtual void PrintStatus()
        {

        }
    }
}
