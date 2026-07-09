using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3
{
    internal class StudentNameComparer : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
          
            if (s1 == null && s2 == null) return 0;
          
            if (s1 == null) return -1;
         
            if (s2 == null) return 1;
           
            return string.Compare(s1.Name, s2.Name);
        }
    }
}

