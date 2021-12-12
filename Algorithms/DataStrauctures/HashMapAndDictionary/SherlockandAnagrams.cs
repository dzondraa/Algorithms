using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.DataStrauctures.HashMapAndDictionary
{
    public class SherlockandAnagrams : IAlgorithm
    {
        public void Execute()
        {
            string s = "cdcd";
            int count = 0;
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i].ToString();
                if (map.ContainsKey(temp))
                    map[temp]++;
                else map.Add(temp, 1);
                for (int j = i + 1; j < s.Length; j++)
                {
                    temp += s[j];
                    temp = temp = String.Concat(temp.OrderBy(c => c));
                    if (map.ContainsKey(temp))
                        map[temp]++;
                    else map.Add(temp, 1);
                }
            }

            foreach (var keyValue in map)
            {
                int val = keyValue.Value;
                if (val > 1)
                {
                    count += (val * (val - 1) / 2);
                }
            }

            Console.WriteLine($"Result: {count}");
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
