namespace תרגיל_כיתה_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplliance[] aplliances = {
                new WashingMachine("LG"),
                new Oven("samsung"),
                new WashingMachine("Bocsh")
        };
            foreach (var a in aplliances)
            {
                a.TurnOn();
            }
}
}
}
