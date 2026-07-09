using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_1
{
    internal class Team
    {
        List<string> players = new List<string>();
        public void AddPlayer(string player)
        {
            players.Add(player);
        }

        public void Print()
        {
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
    }
}
}
