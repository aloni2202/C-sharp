using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה_1
{
    internal class Team
    {
        List<string> players = new List<string>();

        public void AddPlayer(string name)
        {
            players.Add(name);
        }
        public void PrintPlayers()
        {
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
    }
}
}