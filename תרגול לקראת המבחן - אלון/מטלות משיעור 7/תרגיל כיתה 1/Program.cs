namespace תרגיל_כיתה_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            while (true)
            {
                Console.WriteLine("You want to add player ? (y/n)");
                char ans = char.Parse(Console.ReadLine());
                if (ans == 'n' || ans == 'N')
                {
                    break;
                }
                Console.WriteLine("Enter the name of player : ");
                string name = Console.ReadLine();
                team.AddPlayer(name);
            }
            Console.WriteLine();
            Console.WriteLine("Players names :");
            team.Print();
        }
    }
}
