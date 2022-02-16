using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.GreedyAlgorithms
{
    public class MinimumAbsoluteDifferenceInAnArray : IAlgorithm
    {
        public void Execute()
        {
            // sampple input
            var tests = new int[][] {
                new int[] { 3, -7, 0 },
                new int[] {-59, -36, -13, 1,-53, -92, -2, -96, -54, 75 },
            };
            var expectedOutpu = new int[] { 3, 1 };

            for(int testCaseCounter = 0; testCaseCounter < tests.Length; testCaseCounter++)
            {
                var sorted = tests[testCaseCounter].OrderBy(Math.Abs).ToArray();
                // init the helper var (first - second element)
                int min = Math.Abs(sorted[0] - sorted[1]);
                for (int i = 0; i < sorted.Length - 1; i++)
                {
                    var temp = Math.Abs(sorted[i] - sorted[i + 1]);
                    if (temp < min) min = temp;
                }

                bool isOutputCorrect = min == expectedOutpu[testCaseCounter];
                Console.ForegroundColor = isOutputCorrect ? ConsoleColor.Green : ConsoleColor.Red;
                string outputMessage = isOutputCorrect ? $"SUCESSFULLY PASSED SAMPLE TEST {testCaseCounter}" : $"SAMPLE TEST {testCaseCounter} FAILED.";
                Console.WriteLine(outputMessage);
                Console.ForegroundColor = ConsoleColor.White;
            }
            // sort by absolut value
            
        }
    }
}
