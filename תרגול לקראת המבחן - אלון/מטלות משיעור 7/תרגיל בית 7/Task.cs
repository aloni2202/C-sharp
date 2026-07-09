using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית_7
{
    internal class Task : IComparable<Task>
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

        public Task(int taskId , string description , string priority)
        {
            TaskId = taskId ;
            Description = description ;
            Priority = priority ;
        }

        public int CompareTo(Task? other)
        {
            return this.Priority.CompareTo(other.Priority);
        }
    }
}
