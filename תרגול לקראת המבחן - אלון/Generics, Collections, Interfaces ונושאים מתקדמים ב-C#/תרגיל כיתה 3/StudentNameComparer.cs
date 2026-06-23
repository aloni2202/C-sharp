using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3
{
    public class StudentNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null) return 0;
            return string.Compare(x.Name, y.Name);
        }
    }
}
