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
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Dog dog = animal as Dog;
                if (dog != null)
                {
                    dog.Bark();
                }
                Cat cat = animal as Cat;
                if (cat != null)
                {
                    cat.purr();
                }
                Console.WriteLine();

            }
        }
    }
}

