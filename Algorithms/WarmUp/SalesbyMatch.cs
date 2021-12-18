using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.WarmUp
{
    public class SalesbyMatch : IAlgorithm
    {
        public void Execute()
        {
            // using additional array for counting
            // alternative solution would be sorting an array and count the pairs
            var ar = new int[] { 1, 2, 3, 1, 1, 3, 5, 7, 7, 8, 9, 10 };
            int n = ar.Length;
            var store = new int[101];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (++store[ar[i]] % 2 == 0 & store[ar[i]] > 0) count++;
            }
             Console.WriteLine(count);
        }
    }
}
