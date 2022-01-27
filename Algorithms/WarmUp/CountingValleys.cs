using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.WarmUp
{
    public class CountingValleys : IAlgorithm
    {
        public void Execute()
        {
            int steps = 8;
            string path = "UDDDUDUU";

            int level = 0, total = 0;
            
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (++level == 0) total++;
                }
                else level--;
            }
            
            Console.WriteLine($"TOTAL: {total}");
        }
    }
}
