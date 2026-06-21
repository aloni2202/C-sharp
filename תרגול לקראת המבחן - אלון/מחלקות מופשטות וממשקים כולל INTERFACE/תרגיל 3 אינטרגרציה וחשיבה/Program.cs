namespace תרגיל_3_אינטרגרציה_וחשיבה
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[3];

            appliances[0] = new Oven("LG", 1500);
            appliances[1] = new WashingMachine("BOCSH", 4000);
                appliances[2] = new Oven ("samsung",  1999 );
             

            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine($"The brand :{appliances[i].Brand} is cost : {appliances[i].Price}");
                Console.WriteLine();
            }

            Array.Sort(appliances);
            Console.WriteLine();
            Console.WriteLine("After sorting ..");
            Console.WriteLine("----------------------");
            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine($"The brand :{appliances[i].Brand} is cost : {appliances[i].Price}");
                Console.WriteLine();
            }
        }
    }
}
