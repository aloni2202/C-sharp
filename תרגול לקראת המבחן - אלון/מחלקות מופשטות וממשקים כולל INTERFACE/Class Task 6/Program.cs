namespace Class_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] listCars = new Car[]
            {
                //new Car(2014, "Some model"); Error cannot create instance of an abstract class
                new Mazda(2010, "Mazda 3", "Tom"),
                new Audi(2014, "A3", 200)
                };
            string option;
            do
            {
                Console.WriteLine("Please enter:\n1 - Travel of all cars" +
                    "                           \n2 - Print all cars" +
                    "                           \n3 - Sort by gas quantity" +
                    "                           \n4 - Sort by car model" +
                    "                           \n5 - Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":

                        int kilometer, i = 1;
                        foreach (Car item in listCars)
                        {
                            Console.WriteLine("How many kilometers does the journey of car number " + i++ + " take? ");
                            kilometer = int.Parse(Console.ReadLine());
                            item.Drive(kilometer);
                        }
                        i = 0;
                        break;

                    case "2":
                        foreach (Car item in listCars)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        break;

                    case "3":
                        try
                        {
                            Car.sortedByGas = true;
                            Array.Sort(listCars);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            Car.sortedByGas = false;
                            Array.Sort(listCars);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);

                        }
                        break;

                    case "5":
                        Console.WriteLine("bye bye(:");
                        break;

                    default:
                        Console.WriteLine("There is no such option in the menu, try again");
                        break;
                }
            } while (option != "5");
        }
}
}
