using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Q1
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Animal Name : {Name} , Animal Age {Age}";
        }



    }
}
