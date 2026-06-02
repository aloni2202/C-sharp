using System;
using System.Collections.Generic;
using System.Text;

namespace משימת_כיתה___חיבור_למסד_נתונים
{
    internal class Knight
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Power { get; set; }




        public Knight(string firstName , string lastName , string power)
        {
            FirstName = firstName;
            LastName = lastName;
            Power = power;
        }

        public override string ToString()
        {
            return $"{Id}";
        }

    }
}
