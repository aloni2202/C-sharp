using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_3
{
    internal class Employee
    {
        public string name;
        public int salary;

        public Employee(string n, int s)
        {
            name = n;
            salary = s;
        }

        public virtual void Work()
        {
            Console.WriteLine($"The worker {name} is working now");
        }
    }
}
