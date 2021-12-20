using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringManipulation
{
    public class SherlockAndTheValidString : IAlgorithm
    {
        public void Execute()
        {
            // input string -> s
            string s = "aabbccddeefghi";
            const string good = "YES";
            const string bad = "NO";

            if (s.Length <= 3)
            {
                Console.WriteLine(good);
                return;
            }
            int[] letters = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                letters[s[i] - 'a']++;
            }

            Array.Sort(letters);
            int j = 0;
            while (letters[j] == 0)
            {
                j++;
            }

            int min = letters[j];
            int max = letters[25];
            string ret = bad;
            if (min == max) ret = good;
            else
            {
                if (max - min == 1 && max > letters[24] ||
                    min == 1 && letters[j + 1] == max)
                    ret = good;
            }
            Console.WriteLine(ret);
        }
    }
}
