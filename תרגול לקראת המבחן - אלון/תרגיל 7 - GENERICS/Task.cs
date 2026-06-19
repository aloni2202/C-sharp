using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_7___GENERICS
{
    internal class Task :IComparable<Task>
    {
        public int TaskID { get; set; }
        public string Description { get; set; }

        public int Priority { get; set; }

        public Task(int taskID , string description , int priority)
        {
            TaskID  = taskID;
            Description = description;
            Priority = priority;
        }

        public int CompareTo(Task other)
        {
            if (other == null) return 1;
            return this.Priority.CompareTo(other.Priority);
        }
    }
}
