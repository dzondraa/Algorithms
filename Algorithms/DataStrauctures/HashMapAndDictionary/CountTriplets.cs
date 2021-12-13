using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.DataStrauctures.HashMapAndDictionary
{
    public class CountTriplets : IAlgorithm
    {
        public void Execute()
        {
            // The point is to satisfy 3 conditions:

            // - CurrentElement % Ratio == 0
            // - ElementsAfter contains CurrentElement * Ratio
            // - ElementsAfter contains CurrentElement / Ratio
            // (We are tracking elements before and after in 2 seperate Dictionaries)

            // IF TRUE => Add to sum (numberOfAppereance of previous) * (numberOfAppereance of next element)

            // GIVEN INPUT:
            List<long> arr = new List<long> { 1, 3, 9, 9, 27, 81, };
            long r = 3; // ratio

            long sum = 0;
            // Creating map for [number => numOfAppereance]
            Dictionary<long, long> elementsBefore = new Dictionary<long, long>();
            Dictionary<long, long> elementsAfter = new Dictionary<long, long>();
            // At very beggining all the elements will be in 'after' map
            for (int i = 0; i < arr.Count; i++)
            {
                if (elementsAfter.ContainsKey(arr[i]))
                    elementsAfter[arr[i]]++;
                else elementsAfter.Add(arr[i], 1);
            }

            for (int i = 0; i < arr.Count; i++)
            {

                // decrease count of appear. and remove if 0
                if (--elementsAfter[arr[i]] == 0) elementsAfter.Remove(arr[i]);

                if 
                (elementsBefore.ContainsKey(arr[i] / r)
                && elementsAfter.ContainsKey(arr[i] * r)
                && arr[i] % r == 0) sum += elementsBefore[arr[i] / r] * elementsAfter[arr[i] * r];

                // set to 1 or increase if appeared
                if (elementsBefore.ContainsKey(arr[i])) elementsBefore[arr[i]]++;
                else elementsBefore.Add(arr[i], 1);

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"RESULT: {sum}");
            Console.ResetColor();
        }
    }
}
