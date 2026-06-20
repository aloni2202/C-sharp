using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית___שאלה_1_ניהול_חיות
{
    internal class Animals
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Animals(int age , string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return $"Animal name : {Name} , Animal Age : {Age}";
        }
    }
}
