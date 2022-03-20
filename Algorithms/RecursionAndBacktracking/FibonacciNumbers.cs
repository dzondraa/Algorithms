using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.RecursionAndBacktracking
{
    public class FibonacciNumbers : IAlgorithm
    {
        public void Execute()
        {
            Console.WriteLine(Fibonacci(5));
        }
        public static int Fibonacci(int n) {
            int i = 0;
            int j = 1;
            int counter = 1;
            return getNthElement(n, counter, i, j);
        }
        
        static int getNthElement(int n, int counter, int i, int j) {
            counter++;
            if(counter == n) return i + j;
            else return getNthElement(n, counter, j, i + j);
        }
       
    }
}
