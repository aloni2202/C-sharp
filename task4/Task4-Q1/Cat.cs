using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Q1
{
    sealed class Cat : Animal
    {

        public void purr()
        {
            Console.WriteLine($"{Name} is purring : prrr..prrr");
        }
    }

}
