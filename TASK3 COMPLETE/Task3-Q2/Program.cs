namespace Task3_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aircraft[] Aircraft = new Aircraft[4];
            Aircraft[0] = new PassengerPlane(3000, "111", 300);
            Aircraft[1] = new PassengerPlane(2000, "222", 250);
            Aircraft[2] = new FighterJet(6000, "007", true);
            Aircraft[3] = new FighterJet(8000, "777", true);
            for (int i = 0; i < Aircraft.Length; i++)
            {
                if (Aircraft[i] is FighterJet)
                {
                    FighterJet f = (FighterJet)Aircraft[i];
                    f.FireMissile();
                }
                else
                {
                    Aircraft[i].PrintStatus();
                }
            }
        }
    }
}
