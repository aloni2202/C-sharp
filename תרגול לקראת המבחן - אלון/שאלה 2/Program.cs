namespace שאלה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Contact> mySD = new SortedDictionary<string, Contact>();
            PrintOption();
            Console.WriteLine("Please choose from the Menu");
            int choose = int.Parse(Console.ReadLine());

            while (choose != 4)
            {
                switch (choose)
                {
                    case 1:
                        AddContact(mySD);
                        break;
                    case 2:
                        RemoveContact(mySD);
                        break;
                    case 3: PrintAll(mySD);
                        break;
                    case 4: Console.WriteLine("Good Bye");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

                PrintOption();
                choose = int.Parse(Console.ReadLine());

            }
        }

        public static void AddContact(SortedDictionary<string, Contact> mySD)
        {
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the adress : ");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter the phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("is family ? (y/n) : ");
            string fam = Console.ReadLine();
            mySD.Add(name, new Contact(name, adress, phone, fam == "y" ? true : false));
        }



        public static void RemoveContact(SortedDictionary<string, Contact> mySD)
        {
            Console.WriteLine("Enter the index of contact that you want remove : ");
            int index = int.Parse(Console.ReadLine());
            mySD.Remove(mySD.ElementAt(index).Key);
        }

        public static void PrintAll(SortedDictionary<string, Contact> mySD)
        {
            Console.WriteLine("Name     Adress      Phone       IsFamily\t");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var myContact in mySD)
            {
                Console.WriteLine(myContact.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void PrintOption()
        {
            Console.WriteLine(@"Press 1 - Add Contact
Press 2 - Delete Conatact
Press 3 - Print All Contact
Press 4 - Exit");
        }
    }
}
