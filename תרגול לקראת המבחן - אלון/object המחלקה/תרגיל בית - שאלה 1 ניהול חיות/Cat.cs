using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית___שאלה_1_ניהול_חיות
{
    sealed class Cat : Animals
    {
        public Cat(int age, string name) : base(age, name)
        {
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purrrr purrr ...");
        }
    }
}
