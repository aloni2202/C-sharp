using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_2
{
    internal class Rectangle : Shape
    {
        public Rectangle(string color):base(color)
        {
           
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color} rectangle");
        }
    }
}
