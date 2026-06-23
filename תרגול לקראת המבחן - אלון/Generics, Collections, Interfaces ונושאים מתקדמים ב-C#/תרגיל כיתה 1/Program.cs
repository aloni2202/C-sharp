namespace תרגיל_כיתה_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team t1 = new Team();
            while (true)
            {
                Console.WriteLine("You want to add new player ? (Y/N)");
                char ans = char.Parse(Console.ReadLine());
                if (ans == 'N' || ans == 'n')
                {
                    break;
                }
                Console.WriteLine("Enter player name : ");
                string player = Console.ReadLine();

                t1.AddPlayer(player);
            }
            Console.WriteLine();
            Console.WriteLine("Team members : ");
            t1.PrintPlayers();
        }
    }
}

