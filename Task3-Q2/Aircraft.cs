using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Q2
{
    internal class Aircraft
    {
        int altitude;
        string flightNumber;

        public Aircraft(int altitude, string flightNumber)
        {
            this.altitude = altitude;
            this.flightNumber = flightNumber;
        }

        public virtual void PrintStatus()
        {
            Console.Write($"The flight number : {flightNumber} ,  on hight : {altitude} ");
        }
    }
}
