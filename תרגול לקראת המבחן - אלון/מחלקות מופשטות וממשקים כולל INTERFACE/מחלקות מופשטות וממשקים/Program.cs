namespace מחלקות_מופשטות_וממשקים
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[]
            {
                new Oven ("LG"),
                new WashingMachine("Irobot")
            };

            for (int i = 0; i < appliances.Length; i++)
            {
                appliances[i].TurnOn();
            }
        }
    }
}

