namespace שאלה_2____ניהול_מערך_כלי_טיס
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PassengersPlane p1 = new PassengersPlane(10000, "EL AL", 300);
            PassengersPlane p2 = new PassengersPlane(15000, "EL AL", 400);
            FighterJet f1 = new FighterJet(5000, "F-16");
            FighterJet f2 = new FighterJet(6000, "F-35");

            Aircraft[] aircrafts = new Aircraft[] { p1, p2, f1, f2 };

            for (int i = 0; i < aircrafts.Length; i++)
            {
                aircrafts[i].PrintStatus();
                if (aircrafts[i] is FighterJet fighterJet)
                {
                   ((FighterJet)aircrafts[i]).FireMissile();
                }
            }
            
        }
    }
}
