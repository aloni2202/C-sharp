namespace Task4_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog{Name = "moshe" , Age = 10},
                new Cat{Name = "Shoola" , Age = 9}
            };
        }
                public static void ProcessAnimals(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal == null) continue;
                Console.WriteLine(animal.ToString());
                if (animal is Dog dog)
                {
                    dog.Bark();
                }
                Cat cat = animal as Cat;
                if (cat != null)
                {
                    cat.purr();
                }

                Console.WriteLine(new string('-', 30));
            }

        }
        }
    }


