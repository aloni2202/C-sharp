namespace תרגיל_7___GENERICS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            Task T1 = new Task(1, "car wash", 1);
            Task T2 = new Task(2, "sleep", 2);
            Task T3 = new Task(3, "beach time", 3);
            Task T4 = new Task(4, "sex", 2);
            Task T5 = new Task(5, "work", 1);

            taskManager.AddTask(T1);
            taskManager.AddTask(T2);
            taskManager.AddTask(T3);
            taskManager.AddTask(T4);
            taskManager.AddTask(T5);

            taskManager.PrintAllSorted();
            Console.WriteLine();

            taskManager.RemoveTask(3);
            taskManager.PrintAllSorted();
            Console.WriteLine();

            taskManager.UndoRemove();
            taskManager.PrintAllSorted();
            Console.WriteLine();



        }
}
}
