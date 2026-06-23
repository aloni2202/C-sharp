using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_בית
{
    internal class TaskManager
    {
        Dictionary<int, Task> tasks = new Dictionary<int, Task>();
        Stack<Task> UndoHistory = new Stack<Task>();

        public Task GetTask(int TaskId)
        {
            if (tasks.ContainsKey(TaskId))
            {
                return tasks[TaskId];
            }
            return null;
        }

        public void AddTask(Task task)
        {
            if (task != null && tasks.ContainsKey(task.TaskID))
            {
                tasks.Add(task.TaskID, task);
            }
        }

        public void RemoveTask(int taskID)
        {
            if (tasks.ContainsKey(taskID))
            {
                Task taskRemove = tasks[taskID];
                UndoHistory.Push(taskRemove);
            }
        }

        public void UndoRemove()
        {
            if (UndoHistory.Count > 0)
            {
                Task restored = UndoHistory.Pop();

                tasks.Add(restored.TaskID, restored);

                Console.WriteLine($"Task {restored.TaskID} is restored");
            }
            else
            {
                Console.WriteLine("No tasks to Undo");
            }
        }
         public void PrintSorted()
        {
            List<Task> sortedLisy = new List<Task>(tasks.Values);
            sortedLisy.Sort();

            foreach (Task task in sortedLisy)
            {
                Console.WriteLine($"{task.TaskID} , {task.Description} , {task.Priority}");
            }
        }
}
}

