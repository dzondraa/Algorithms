using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.RecursionAndBacktracking
{
    public class DavisStaircase : IAlgorithm
    {
        public void Execute()
        {
            Console.WriteLine(stepPerms(5));
            Console.Read();
        }

        public static int stepPerms(int n)
        {
                if(n <= 1) return 1;
                int steps = n;
                var pathsArr = new int[steps + 1];
                pathsArr[0] = 1;
                pathsArr[1] = 1;
                pathsArr[2] = 2;

                for (int i = 3; i <= steps; i++)
                {
                    pathsArr[i] = pathsArr[i - 1] + pathsArr[i - 2] + pathsArr[i - 3];
                }
                
                return pathsArr[steps];
        }
    }
}
