using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringManipulation
{
    public class AlternatingCharacters : IAlgorithm
    {
        public void Execute()
        {
            // input string -> s
            string s = "ABABABAB";
            int count = 0;
            char previous = 'C';
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == previous) count++;
                else previous = s[i];
            }
            Console.WriteLine(count);
        }
    }
}
