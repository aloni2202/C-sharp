namespace תרגיל_כיתה_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 0;
            int maxIndex  = -1;  
            Student[][] students = new Student[3][];
            
                students[0] = new Student[] { new Student("alon", 100), new Student("alon", 100) };
                students[1] = new Student[] { new Student("yosi", 80), new Student("anat", 99), new Student("michal", 40) };
                students[2] = new Student[] { new Student("dana", 90), new Student("anat", 20), new Student("rivka", 79), new Student("maya", 39) };
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].Length > maxLength)
                    {
                        maxLength = students[i].Length;
                        maxIndex = i;
                    }
                }
                Console.WriteLine("The longest array is : ");
                Console.WriteLine(maxLength);
                Console.WriteLine();
                Array.Sort(students[maxIndex], new StudentNameComparer());

                foreach (Student student in students[maxIndex])
                {
                    Console.WriteLine($"Student : {student.Name} Grade :  {student.Grade}");
                }
                Console.WriteLine();
            }
        }
    }

