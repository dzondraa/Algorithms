using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Miscellaneous 
{
    // The problem also known as - Two Sum problem
    public class FlippingBits : IAlgorithm
    {
        public void Execute()
        {
            Console.WriteLine(flippingBits(23));
        }

        public static long flippingBits(long n)
        {
            return 4294967295 - n;
        }


    }

    
}
