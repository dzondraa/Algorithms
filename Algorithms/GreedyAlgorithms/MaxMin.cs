using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.GreedyAlgorithms
{
    public class MaxMin : IAlgorithm
    {
        public void Execute()
        {
            int result = maxMin(2, new List<int> { 1, 4, 7, 2 });
            Console.WriteLine($"Output = {result}");
        }

        public static int maxMin(int k, List<int> arr)
        {
            // when we know that the array is sorted, it is easy to compare the chunks
            // and possible to skip calculations, also as (finding min and max for each chunk)
            arr.Sort(); // sorting is the key of this solution and a 'hack'
            int output = arr[arr.Count - 1];
            for(int i = 0; i + k - 1 < arr.Count; i++) {
                var temp = arr[i + k - 1] - arr[i];
                if(temp < output) output = temp; 
            }
            return output;
        }
    }
}
