using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
	public class FindNearestSmallerNumber : IAlgorithm
	{
		public void Execute()
		{


			var input = new int[] { 2, 6, 4, 7, 9, 4, 3, 4 };
			// Should be output
			var result = new int[input.Length];

			// trace through array
			for (int i = 0; i < input.Length; i++)
			{

				int ComparingElement = input[i];

				int flag = 0;
				int toAdd = -1;

				for (int x = i - 1; x >= 0; x--)
				{
					if (flag == 1) break;
					if (input[x] < ComparingElement)
					{
						flag = 1;
						toAdd = input[x];
						break;
					}
				}

				for (int y = i + 1; y < input.Length; y++)
				{

					if (flag == 1) break;
					if (input[y] < ComparingElement)
					{
						flag = 1;
						toAdd = input[y];
						break;
					}
				}

				result[i] = toAdd;

			}

			Console.WriteLine("Hello World");
			foreach (int i in result) Console.Write(i + ", ");
			Console.Read();
		}
	}
}
