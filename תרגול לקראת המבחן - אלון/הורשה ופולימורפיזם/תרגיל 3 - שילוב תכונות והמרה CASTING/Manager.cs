using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_3___שילוב_תכונות_והמרה_CASTING
{
    internal class Manager : Employee
    {
        public int teamSize;

        public Manager(string n, int s, int t) : base(n, s)
        {
            teamSize = t;
        }

        public override void Work()
        {
            Console.WriteLine($"The mannager {name} is mannage now {teamSize} employees");
        }

        public void AssignBonus()
        {
            Console.WriteLine($"{name} can aproove bonuses");
        }
    }
}
