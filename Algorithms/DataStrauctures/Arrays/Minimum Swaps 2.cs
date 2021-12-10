using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStrauctures.Arrays
{
    public class Minimum_Swaps_2 : IAlgorithm
    {
        public void Execute()
        {
            var arr = new int[] { 1, 3, 5, 2, 4, 6, 7 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    count++;
                    if (arr[arr[i] - 1] != arr[i])
                        i = 0;
                }
            }
            Console.WriteLine("RESULT: " + count + "\n");
        }
    }
}
