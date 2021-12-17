using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class FraudulentActivityNotifications : IAlgorithm
    {
        // In cases like this, where we have a predefined range of values in the array
        // the perfect way to go is Quick Sort algorithm.
        // 1. Creating counting buffer array (length 201 -> our case)
        // 2. On each iteration acting like a queue (FIFO)
        // 3. Walk through couning buffer array and calculating median 
        public void Execute()
        {
            var expenditure = new List<int>() { 1, 2, 3, 4, 4 };
            int d = 4;
            int result = 0;
            var countArr = new int[200];
            int medianPosition;
            if (d % 2 == 0)
                medianPosition = d / 2;
            else
                medianPosition = (d / 2) + 1;

            for (int i = 0; i < d; i++)
            {
                countArr[expenditure[i]]++;
            }

            for(int i = d; i < expenditure.Count; i++)
            {
                int median = findMedian(countArr, d, medianPosition);
                if (median <= expenditure[i]) result++;
                countArr[expenditure[i - d]]--;
                countArr[expenditure[i]]++;
                //Console.WriteLine($"MEDIAN: {median}\n");
            }

            Console.WriteLine(result); 
        }

        // Minimizing the number of iteration by adding counted appearences to counter, not 1
        static int findMedian(int[] countArr, int d, int medianPosition)
        {
            int j = 0;
            int counter = 0;
            //int[] copyArr = new int[200];
            int left = 0;
            int right = 0;
            //Array.Copy(countArr, copyArr, 200);
            while (counter < medianPosition)
            {
                counter += countArr[left];
                left++;
            }

            // step back one time
            right = left;
            left -= 1;

            if(counter > medianPosition || d % 2 != 0)
            {
                return left * 2;
            }
            else
            {
                while (countArr[right] == 0)
                    right++;

                float temp = ((float)left + (float)right) / 2;
                return (int)(temp * 2);
            }
        }
    }
}
