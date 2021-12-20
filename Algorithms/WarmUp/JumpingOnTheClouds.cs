using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.WarmUp
{
    class JumpingOnTheClouds : IAlgorithm
    {
        public void Execute()
        {
            // input -> c
            var c = new List<int> { 0, 0, 1, 0, 0, 1, 0, };

            int current = 0;
            int count = 0;
            while (current < c.Count - 1)
            {
                if (current >= c.Count - 2)
                {
                    count++;
                    break;
                }
                Console.WriteLine("CURRENT : " + current);
                if (c[current + 2] != 1)
                    current += 2;
                else
                    current += 1;

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
