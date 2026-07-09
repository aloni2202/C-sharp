using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית_7
{
    internal class TaskManager
    {
        Dictionary<int, Task> myTasks;
        Stack<Task> undoHistory;

        public TaskManager()
        {
            myTasks = new Dictionary<int, Task>();
            undoHistory = new Stack<Task>();
        }
        public Task GetTask(int taskID)
        {
            if (myTasks.ContainsKey(taskID))
            {
                return myTasks[taskID];
            }
            else
            {
                return null;
            }
        }
        public  void AddTask()
        {

        }
    }
}
