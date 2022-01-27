using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.WarmUp
{
    public class RepeatedString : IAlgorithm
    {
        public void Execute()
        {
            // abaabaaba|a
            // -> 'a' after | is offset (the characters that left after the deviding to chunks
            // -> we know how many repetitions 1 chunk has
            // -> final forumla -> oneChunkCount * (n / s.Length) + offsetCount

            int n = 10;
            string s = "aba";

            long offset = n % s.Length;
            long oneChunkCount = 0, offsetCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') oneChunkCount++;
                if (s[i] == 'a' && i < offset) offsetCount++;
            }

            Console.WriteLine("Total: " + (oneChunkCount * (n / s.Length) + offsetCount));
        }
    }
}
