using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.GreedyAlgorithms
{
    public class GreedyFlorist : IAlgorithm
    {
        public void Execute()
        {
            int[] c = new int[] { 2, 5, 6 };
            int k = 2;
            Array.Sort(c);
            int bound = 0;
            int index = 0;
            int totalPrice = 0;

            for (int i = c.Length - 1; i >= 0; i--)
            {
                totalPrice += (index + 1) * c[i];
                bound++;

                if (bound == k)
                {
                    bound = 0;
                    index++;
                }
            }

            Console.WriteLine(totalPrice);
        }
    }
}
