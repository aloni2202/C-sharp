namespace תרגיל_כיתה_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longestArray = 0;
            Student[][] students = new Student[3][];
            students[0] = new Student[] {new Student("yossi" , 100) , new Student("michal", 90) , new Student("asaf", 70) };
            students[1] = new Student[] { new Student("yoni", 30), new Student("roni", 50)};
            students[2] = new Student[] { new Student("sigal", 89), new Student("ziv",99) , new Student("ravid" ,80) , new Student("or" , 69)};

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Length > students[longestArray].Length)
                {
                    longestArray = i;
                }
            }
            Console.WriteLine("The longest array is :");
            Console.WriteLine(longestArray);

            Array.Sort(students[longestArray], new StudentNameComparer());

            foreach (Student student in students[longestArray])
            {
                Console.WriteLine($"Name : {student.Name} Grade : {student.Grade}");
            }
            Console.WriteLine();
}
}
}
