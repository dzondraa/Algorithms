using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringManipulation
{
    public class MakingAnagrams : IAlgorithm
    {
        public void Execute()
        {
            // input strings -> (a,b)
            string a = "cde";
            string b = "abc";

            Dictionary<char, int> map = new Dictionary<char, int>();
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(a[i]))
                    map[a[i]]++;
                else map.Add(a[i], 1);
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (map.ContainsKey(b[i]))
                    map[b[i]]--;
                else map.Add(b[i], -1);
            }

            foreach (var kv in map)
            {
                result += Math.Abs(kv.Value);
            }

            Console.WriteLine(result);
        }
    }
}
