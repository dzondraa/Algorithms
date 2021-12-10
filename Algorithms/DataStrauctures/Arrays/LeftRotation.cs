using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStrauctures.Arrays
{
    class LeftRotation : IAlgorithm
    {
        public void Execute()
        {
            var a = new List<int> { 98 ,67 ,35 ,1 ,74 ,79 ,7 ,26 ,54 ,63 ,24 ,17 ,32 ,81 };
            int d = 7;
            int numberOfRotations = d % a.Count;
            int counter = 0;
            int current = a[a.Count - 1];
            int next = 0;
            int i = a.Count - 1;
            while (true)
            {
                if (counter == a.Count) break;
                if (i - numberOfRotations >= 0)
                {
                    next = a[i - numberOfRotations];
                    a[i - numberOfRotations] = current;
                    i -= numberOfRotations;
                }
                else
                {
                    next = a[a.Count - (numberOfRotations - i)];
                    a[a.Count - (numberOfRotations - i)] = current;
                    i = a.Count - (numberOfRotations - i);
                }
                current = next;
                counter++;
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(a);
        }

        private void AlternativeSolution()
        {
            var a = new List<int> { 98, 67, 35, 1, 74, 79, 7, 26, 54, 63, 24, 17, 32, 81 };
            int d = 7;
            int numberOfRotations = d % a.Count;
            List<int> b = new List<int>(a.Count);
            for (int x = 0; x < a.Count; x++) b.Add(0);

            for (int i = 0; i < a.Count; i++)
            {
                if (i - numberOfRotations >= 0) b[i - numberOfRotations] = a[i];
                else b[a.Count - (numberOfRotations - i)] = a[i];
            }

            return b;
        }
    }
}
