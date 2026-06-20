using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_2____ניהול_מערך_כלי_טיס
{
    internal class FighterJet : Aircraft
    {
        bool missiLesLoaded;
        public FighterJet(int a, string f) : base(a, f)
        {
            missiLesLoaded = true;
        }

        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Missiles Loaded: {missiLesLoaded}");
        }

        public void FireMissile()
        {
            if (missiLesLoaded)
            {
                Console.WriteLine("Missile Fired !! ");
                missiLesLoaded = false;
            }
        }
    }
}
