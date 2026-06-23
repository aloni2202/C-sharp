namespace תרגיל_בית
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            // 1. הוספת משימות עם עדיפויות שונות (1 הכי גבוה, 3 הכי נמוך)
            Console.WriteLine("--- Adding Tasks ---");
            manager.AddTask(new Task(101, "Low priority task", 3));
            manager.AddTask(new Task(102, "High priority task", 1));
            manager.AddTask(new Task(103, "Medium priority task", 2));

            // 2. בדיקת המיון וההדפסה (Array.Sort)
            Console.WriteLine("\n--- Testing Print All Sorted (Should show 1 then 2 then 3) ---");
            manager.PrintSorted();

            // 3. בדיקת מחיקה (העברה למחסנית)
            Console.WriteLine("\n--- Deleting Task 102 (High priority) ---");
            manager.RemoveTask(102);
            manager.PrintSorted(); // משימה 102 לא אמורה להופיע כאן

            // 4. בדיקת שחזור (Undo - החזרה מהמחסנית למילון)
            Console.WriteLine("\n--- Testing Undo Remove ---");
            manager.UndoRemove();
            manager.PrintSorted(); // משימה 102 אמורה לחזור למקומה

            Console.ReadLine(); // משאיר את החלון פתוח
        }
    }
}
