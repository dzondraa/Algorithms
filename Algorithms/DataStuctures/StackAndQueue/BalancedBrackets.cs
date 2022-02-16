using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStuctures.StackAndQueue
{
    public class BalancedBrackets : IAlgorithm
    {
        public void Execute()
        {
            var tests = new string[] { "[]", "[[", "[]{{}" };
            var expectedOutput = new string[] { "YES", "NO", "NO" };
            for(int testCaseNum = 0; testCaseNum < tests.Length; testCaseNum++)
            {
                var output = isBalanced(tests[testCaseNum]) == expectedOutput[testCaseNum] 
                    ? $"Test {testCaseNum} passed!" : $"Test {testCaseNum} failed!";
                Console.ForegroundColor = isBalanced(tests[testCaseNum]) == expectedOutput[testCaseNum] ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine(output);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private string isBalanced(string s)
        {
            if (s.Length % 2 != 0) return "NO";
            Stack<char> openCloseBracket = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var currentChar = s[i];
                if (currentChar == '{' || currentChar == '(' || currentChar == '[')
                {
                    openCloseBracket.Push(currentChar);
                }
                else
                {
                    if (openCloseBracket.Count == 0) return "NO";

                    var dropped = openCloseBracket.Pop();

                    if (dropped == '{' && currentChar == '}')
                        continue;

                    if (dropped == '[' && currentChar == ']')
                        continue;

                    if (dropped == '(' && currentChar == ')')
                        continue;

                    return "NO";
                }
            }
            return openCloseBracket.Count > 0 ? "NO" : "YES";
        }
    }
}
