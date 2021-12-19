using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class MergeSort_CountingInversions : IAlgorithm
    {

        // If you need more explanation for this problem. Please go to https://www.youtube.com/watch?v=KF2j-9iSf4Q&t=471s
        // There is a merge sort explained well. Should be enough for this challenge
        public void Execute()
        {
            var input = new int[] { 3,2,1 };
            long result = mergeSort(input, new int[input.Length], 0, input.Length - 1);
            Console.WriteLine(result);
        }

        static long mergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            long count = 0;
            if (leftStart >= rightEnd)
                return count;

            int middle = (leftStart + rightEnd) / 2;
            count += mergeSort(array, temp, leftStart, middle);
            count += mergeSort(array, temp, middle + 1, rightEnd);
            count += mergeHalves(array, temp, leftStart, rightEnd);
            return count;

        }

        static long mergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            // concept called "Explanatory variable" -> unnecessary, but explains what we stored
            int middle = (rightEnd + leftStart) / 2;
            int leftEnd = middle;
            int rightStart = middle + 1;
            int size = rightEnd - leftStart + 1;
            long count = 0;
            // indices
            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                }
                else
                {
                    temp[index] = array[right];
                    count += right - index;
                    right++;
                }

                index++;

            }
            // copying the rest of elements
            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, size);

            return count;
        }
    }
}
