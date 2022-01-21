using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringManipulation
{
    public class CommonChild : IAlgorithm
       
    {
        public void Execute()
        {

            /*
             * 
            Longest common subsequence algorithm
            PSEUDO: 

            IF (stringA[i] == stringB[j])
                LCS[i,j] = 1 + (LCS[i-1, j-1])
            ELSE
                LCS[i,j] = max(LCS[i-1, j], LCS[i, j-1])
            */
            
            int count = 0;
            string s1 = "BD";
            string s2 = "ABCD";
            
            // init Memoization table
            // 
            List<List<int>> _memo = new List<List<int>>();
            
          /*
            MEMOIZATION OR STORE TABLE FOR DYNAMIC PROGRAMING || RECURSIVE SOLUTION
            *Memoization -> process of storing recursion or iteration results to improve time performance
                 ___________________
                | 0 | A | B | C | D |
                |-------------------|
                | B | 0 | 0 | 0 | 0 |
                |-------------------|
                | D | 0 | 1 | 1 | 2 |
                |___________________|
            
           */

            for(int i = 0; i < s1.Length + 1; i++)
            {
                _memo.Add(new List<int>(new int[s2.Length + 1]));
            }

           

            // Algorithm
            for(int i = 1; i < s1.Length + 1; i++)
            {
                for(int j = 1; j < s2.Length + 1; j++)
                {
                    if(s1[i - 1] == s2[j - 1])
                    {
                        _memo[i][j] = 1 + _memo[i - 1][j - 1]; 
                    } else
                    {
                        _memo[i][j] = Math.Max(_memo[i - 1][j], _memo[i][j - 1]);
                    }
                }
            }

            Console.WriteLine($"RESULT = {_memo[_memo.Count - 1][_memo[0].Count - 1]}");

        }
    }
}
