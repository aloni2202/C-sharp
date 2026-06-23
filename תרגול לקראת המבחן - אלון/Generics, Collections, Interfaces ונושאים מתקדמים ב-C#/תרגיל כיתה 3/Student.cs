using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_3
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name , int grade)
        {
            Name = name;
            Grade = grade;
        }

        public int CompareTo(Student? obj)
        {
            Student other = (Student)obj;
            if (other.Grade == null) return 1;
            if (this.Grade < other.Grade) return -1;
            if (this.Grade > other.Grade) return 1;
            return 0;   
        }
     
    }
}
