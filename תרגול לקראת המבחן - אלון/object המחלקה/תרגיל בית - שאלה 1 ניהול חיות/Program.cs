using System.Security.Cryptography.X509Certificates;

namespace תרגיל_בית___שאלה_1_ניהול_חיות
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals[] animals =new Animals[]
            {
                new Dog (8 , "yossi"),
                new Cat (10 , "nati")
            };
            ProcessAnimals(animals);
        }

            public static void ProcessAnimals(Animals[] animals)
        {
            foreach (Animals animal in animals)
            {
                if (animal == null) continue;
                Console.WriteLine(animal.ToString());

                if (animal is Dog dog)
                {
                    dog.Bark();
                }
               
                if (animal is Cat cat)
                {
                    cat.Purr();
                }
            }
        }
    }
}
