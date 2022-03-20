using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.RecursionAndBacktracking
{
    public class Primality : IAlgorithm
    {
        public void Execute()
        {
            Console.WriteLine(primality(7));
            Console.Read();
        }

        public static string primality(int n)
        {
            if(n == 1) return "Not prime";
            else 
            {
                bool check = true;
                int l = (int)Math.Sqrt(n);
                for(int i = 2; i <= l; ++i) 
                    if(n % i == 0)
                    {
                        check = false; 
                        i = n;
                    }
                if(check) return "Prime";
                else return "Not prime";
            }
        }
    }
}
