using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Search
{
    // The problem also known as - Two Sum problem
    public class Pairs : IAlgorithm
    {
        public void Execute()
        {
            Console.WriteLine(pairs(1, new List<int> {1,2,3,4,5}));
        }

        public static int pairs(int k, List<int> arr)
        {
            int max = arr.Max();
            int totalPairs = 0;
            Dictionary<int, int> valueAndReps = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++)
                if (valueAndReps.ContainsKey(arr[i]))
                    valueAndReps[arr[i]]++;
                else
                    valueAndReps.Add(arr[i], 1);


            for (int i = 0; i < arr.Count; i++)
            {
                if (valueAndReps.ContainsKey(arr[i]) && valueAndReps.ContainsKey(arr[i] + k))
                {
                    totalPairs += valueAndReps[arr[i]] * valueAndReps[arr[i] + k];
                }
                if (valueAndReps.ContainsKey(arr[i]) && valueAndReps.ContainsKey(arr[i] + k))
                {

                }
            }

            return totalPairs;

        }

    }


}
