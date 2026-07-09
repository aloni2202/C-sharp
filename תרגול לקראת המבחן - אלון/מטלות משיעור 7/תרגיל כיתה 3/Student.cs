using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public int CompareTo(Student? obj)
        {
            if (obj == null) return 1;
            return this.Grade.CompareTo(obj.Grade);
        }
    }
    }
    
