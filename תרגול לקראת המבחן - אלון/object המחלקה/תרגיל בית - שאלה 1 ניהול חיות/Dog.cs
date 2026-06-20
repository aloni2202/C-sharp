using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית___שאלה_1_ניהול_חיות
{
    internal class Dog : Animals
    {
        public Dog(int age, string name) : base(age, name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is bark bark ... ");
        }
    }
}
