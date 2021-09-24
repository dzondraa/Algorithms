using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Dynamic
{
    // PROBLEM: https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem?h_r=internal-search
    public class RecursiveStaircase : IAlgorithm
    {
        public void Execute()
        {
            int steps = 7;
            var pathsArr = new int[steps + 1];
            pathsArr[0] = 1;
            pathsArr[1] = 1;
            pathsArr[2] = 2;

            for (int i = 3; i <= steps; i++)
            {
                pathsArr[i] = pathsArr[i - 1] + pathsArr[i - 2] + pathsArr[i - 3];
            }
            Console.WriteLine($"RESULT {pathsArr[steps]}");
            Console.Read();
        }
    }
}
