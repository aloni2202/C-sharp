namespace תרגיל_כיתה_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplliance[] aaa = new Aplliance[3];

            aaa[0] = new Oven("LG", 1500);
            aaa[1] = new WashingMachine("Samsung", 2000);
            aaa[2] = new Oven("bosch", 1999);

            Console.WriteLine("Products befoe sorting : ");
            for (int i = 0; i < aaa.Length; i++)
            {
                Console.WriteLine(aaa[i].Brand + " : " + aaa[i].Price);
            }
            Array.Sort(aaa);
            Console.WriteLine("Products after sorting : ");
            for (int i = 0; i < aaa.Length; i++)
            {
                Console.WriteLine(aaa[i].Brand + " : " + aaa[i].Price);
            }

        }
    }
}
