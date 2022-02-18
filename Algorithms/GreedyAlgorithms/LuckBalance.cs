using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.GreedyAlgorithms
{
    public class LuckBalance : IAlgorithm
    {
        public void Execute()
        {
            int k = 3;
            List<List<int>> contests = new List<List<int>>
            {
                new List<int> { 5, 1 },
                new List<int> { 2, 1 },
                new List<int> { 1, 1 },
                new List<int> { 8, 1 },
                new List<int> { 10, 0},
                new List<int> { 5, 0 }
            };
            var importantContests = new List<int>();
            int importantContestCount = 0;
            int bestLuckBalance = 0;

            for (int i = 0; i < contests.Count; i++)
            {
                if (contests[i][1] == 1)
                {
                    importantContestCount++;
                    importantContests.Add(contests[i][0]);
                }
                bestLuckBalance += contests[i][0];
            }

            if (importantContestCount <= k)
            {
                Console.WriteLine(bestLuckBalance);
                return;
            }
            importantContests.Sort();

            for (int i = 0; i < importantContestCount - k; i++)
                bestLuckBalance -= importantContests[i] * 2;

            Console.WriteLine(bestLuckBalance);
        }
    }
}
