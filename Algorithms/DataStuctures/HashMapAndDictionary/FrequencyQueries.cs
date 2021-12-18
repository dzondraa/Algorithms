using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStrauctures.HashMapAndDictionary
{
    public class FrequencyQueries : IAlgorithm
    {
        public void Execute()
        {
            // Idea is to track frequencies for each element
            // But also to track how much elements with exact frequencie is there
            // so we will create 2 Dictionaries to avoid searching by value on query type 3 -> O(n)
            // * Point is to always get elemet from Dictionary/HashMap by it's key -> O(1) *

            // GIVEN INPUT 
            var queries = new List<List<int>> { 
                new List<int> { 1, 4 },
                new List<int> { 1, 1003 },
                new List<int> { 1, 4 },
                new List<int> { 2, 4 },
                new List<int> { 2, 4 },
                new List<int> { 2, 4 },
                new List<int> { 2, 4 },
                new List<int> { 1, 4 },
                new List<int> { 1, 4 },
                new List<int> { 1, 4 },
                new List<int> { 1, 4 } };

            var results = new List<int>();
            var numberAppears  = new Dictionary<int, int>();
            var numbersWithNAppears = new Dictionary<int, int>();

            // walk through queries and execute each one
            for (int i = 0; i < queries.Count; i++)
            {
                var value = queries[i][1];
                int oldVal = 0;
                int newVal = 0;

                // insert 
                if (queries[i][0] == 1)
                {
                    if (numberAppears.ContainsKey(value))
                    {
                        newVal = ++numberAppears[value];
                        oldVal = newVal - 1;

                        if (numbersWithNAppears.ContainsKey(oldVal) && numbersWithNAppears[oldVal] > 0)
                            numbersWithNAppears[oldVal]--;
                        else if(oldVal > 0) numbersWithNAppears.Add(oldVal, 1);

                        if (numbersWithNAppears.ContainsKey(newVal)) numbersWithNAppears[newVal]++;
                        else numbersWithNAppears.Add(newVal, 1);
                    }
                    else
                    {
                        numberAppears.Add(value, 1);

                        if (numbersWithNAppears.ContainsKey(1)) 
                            numbersWithNAppears[1]++;
                        else
                            numbersWithNAppears.Add(1, 1);
                    }


                }
                // delete one occurence
                else if (queries[i][0] == 2)
                {
                    oldVal = 0;
                    newVal = 0;
                    if (numberAppears.ContainsKey(value))
                    {
                        if (numberAppears[value] - 1 == -1) continue;
                        newVal = --numberAppears[value];

                        oldVal = newVal + 1;

                        if (numbersWithNAppears.ContainsKey(oldVal) && numbersWithNAppears[oldVal] > 0)
                        {
                            if (numbersWithNAppears[oldVal] > 0) numbersWithNAppears[oldVal]--;
                        }

                        if (numbersWithNAppears.ContainsKey(newVal)) numbersWithNAppears[newVal]++;
                        else if(newVal > 0) numbersWithNAppears.Add(newVal, 1);
                    }

                }
                // check if exist (prints 1 or 0)
                else if (queries[i][0] == 3)
                {
                    int res = 0;
                    numbersWithNAppears.TryGetValue(value, out res);
                    results.Add(res > 0 ? 1 : 0);
                }
            }

            Console.WriteLine(results);
        }
    }
}
