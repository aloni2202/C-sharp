using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית
{
    internal class Task : IComparable<Task>
    {
        public int TaskID { get; set; }
        public string Description { get; set; }

        public int Priority { get; set; }

        public Task(int taskID, string descripton, int prioeity)
        {
            TaskID = taskID;
            Description = descripton;
            Priority = prioeity;
        }

        public int CompareTo(Task? other)
        {
            if(other == null) return 1;
            if (this.Priority > other.Priority) return 1;
            if (this.Priority < other.Priority) return -1;
            return 0;
        }
           
        }
    }


