using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Dynamic
{
    class CrosswordPuzzle : IAlgorithm
    {
        // PROBLEM: https://www.hackerrank.com/challenges/crossword-puzzle/problem
        public void Execute()
        {
            List<string> crossword = new List<string> {
                "+-++++++++",
                "+-++++++++",
                "+-++++++++",
                "+-----++++", 
                "+-+++-++++",
                "+-+++-++++",
                "+++++-++++",
                "++------++",
                "+++++-++++",
                "+++++-++++"
            };

            string words = "LONDON;DELHI;ICELAND;ANKARA";
            Dictionary<int, List<string>> order = new Dictionary<int, List<string>>();

            foreach (string word in words.Split(";"))
            {
                if (order.ContainsKey(word.Length)) order[words.Length].Add(word);
                else order.Add(words.Length, new List<string>() { word });
            }

            for (int i = 0; i < crossword.Count; i++)
            {
                int indexOfMinus = crossword[i].IndexOf("-");
                if (indexOfMinus > 0)
                {

                    if (crossword[i + 1][indexOfMinus] == '-')
                    {
                        countVertical(indexOfMinus, i, crossword);
                    } 
                    else
                    {
                        countHorizont(indexOfMinus, i, crossword);
                    }
                }
            }


            static void countHorizont(int x, int y, List<string> crossword)
            {
                int start = y;
                int up = y;
                int down = y;
                int size = 0;
                while(crossword[up - 1][x] == '-' || crossword[down + 1][x] == '-')
                {
                    if (crossword[up - 1][x] == '-')
                    {
                        up--;
                        size++;
                    }
                    if (crossword[down + 1][x] == '-')
                    {
                        down++;
                        size++;
                    }

                }
                


            }

            static void countVertical(int x, int y, List<string> crossword)
            {

            }
        }
    }

    public struct Word
    {
        public Word(double x, double y, string val)
        {
            X = x;
            Y = y;
            wordValue = val;
        }

        public double X { get; }
        public double Y { get; }
        public string wordValue { get; }

    }
}
