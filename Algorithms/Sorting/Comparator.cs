using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class Comparator : IAlgorithm
    {
        public void Execute()
        {
            var players = new List<Player>();
            players.Add(new Player("John" , 50));
            players.Add(new Player("Angelo", 10));
            players.Add(new Player("Anando", 10));

            Array.Sort(players.ToArray(), new Checker());
            Console.WriteLine(players[1].name);

        }
    }

    public class Player
	{
		public string name;
		public int score;

		public Player(String name, int score)
		{
			this.name = name;
			this.score = score;
		}
	}


    class Checker : IComparer<Player> {
    // Comparing logic for players by priority:
    // 1. By score DESC
    // 2. BY name ASC
    public int Compare(Player a, Player b)
    {
        if (a.score < b.score)
        {
            return 1;
        }
        else if (a.score > b.score)
        {
            return -1;
        }
        else
        {

            for (int i = 0; i < Math.Min(a.name.Length, b.name.Length); i++)
            {
                if (a.name[i] < b.name[i]) { return -1; }
                if (b.name[i] < a.name[i]) { return 1; }
            }
            return a.name.Length < b.name.Length ? -1 : 1;
        }
    }

}
}
