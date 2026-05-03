using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Q2
{
    internal class FighterJet : Aircraft
    {
        public bool missilesLoaded;
        public FighterJet(int altitude, string flightNumber, bool missilesLoaded) : base(altitude, flightNumber)
        {
            this.missilesLoaded = missilesLoaded;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();

        }

        public void FireMissile()
        {
            PrintStatus();
            Console.WriteLine(" , Missile Fired !");
            Console.WriteLine("------------------------------------------------------------------------------------");
            missilesLoaded = false;
        }
        
    }
}
