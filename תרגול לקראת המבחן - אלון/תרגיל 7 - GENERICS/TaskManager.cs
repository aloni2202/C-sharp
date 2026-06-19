using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_7___GENERICS
{
    internal class TaskManager
    {
        private Dictionary<int, Task> myTM;
        private Stack<Task> undoHistory;

        public TaskManager()
        {
            myTM = new Dictionary<int, Task>();
            undoHistory = new Stack<Task>();
        }
        public Task GetTask(int taskID)
        {
            if (myTM.ContainsKey(taskID))
            {
                return myTM[taskID];
            }
            return null;
        }

        public void AddTask(Task newTask)
        {
            myTM.Add(newTask.TaskID, newTask);
        }

        public void RemoveTask(int taskID)
        {
            if (myTM.ContainsKey(taskID))
            {
                Task taskToDelete = myTM[taskID];
                undoHistory.Push(taskToDelete);
                myTM.Remove(taskID);
            }
        }
        public void UndoRemove()
        {
            if (undoHistory.Count > 0)
            {
                Task restoresTask = undoHistory.Pop();
                myTM.Add(restoresTask.TaskID, restoresTask);
            }
            else
            {
                Console.WriteLine("NO Tasks to restored !");
            }
        }

        public void PrintAllSorted()
        {
            List<Task> sortedList = new List<Task>(myTM.Values);

            foreach (var task in sortedList)
            {
                Console.WriteLine($"ID : {task.TaskID} Description : {task.Description} Priority : {task.Priority}");
            }
        }
    }
}

