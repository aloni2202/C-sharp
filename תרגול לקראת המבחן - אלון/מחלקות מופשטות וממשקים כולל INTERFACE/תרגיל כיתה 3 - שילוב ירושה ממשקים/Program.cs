namespace תרגיל_כיתה_3___שילוב_ירושה_ממשקים
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[]
            {
                appliances[0] = new Oven{Brand = "LG" , Price = 1500},
                appliances[1] = new WashingMachine{Brand = "BOCSH" , Price = 4000},
                appliances[2] = new Oven{Brand = "samsung" , Price = 1999}
             };

            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine($"{appliances[i].Brand} + {appliances[i].Price}");
            }

            Array.Sort( appliances );

            Console.WriteLine("After sorting ..");
            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine($"{appliances[i].Brand} + {appliances[i].Price}");
            }
        }
    }
}
