using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace תרגיל_כיתה_2
{
    internal class Shape
    {
        public string color;

        public Shape(string c)
        {
            color = c;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing {color} shape");
        }
    }
}
