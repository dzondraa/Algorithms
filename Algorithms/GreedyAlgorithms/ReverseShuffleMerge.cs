using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.GreedyAlgorithms
{
    public class ReverseShuffleMerge : IAlgorithm
    {
        public void Execute()
        {
            string input = "eggegg";
            Console.WriteLine(reverseShuffleMerge(input));
        }

        public static string reverseShuffleMerge(string str)
        {
            string solution = "";
            int n = str.Length;
            int[] unused = new int[26];
            int[] used = new int[26];
            int[] required = new int[26];
            char[] res = new char[100000];
            int j = 0;


            //filling array mapping char freq
            for (int i = 0; i < n; i++)
            {
                unused[str[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                required[i] = unused[i] / 2;
            }

            // last character
            char ch = str[n - 1];
            int ch_position = ch - 'a'; // index present in above arrays
            res[j++] = ch;
            unused[ch_position]--;
            used[ch_position]++;

            //rest of char 
            //add ---- req is smaller than pres
            // ch smaller 
            //ch bigger

            for (int i = n - 2; i >= 0; i--)
            {
                ch = str[i];
                ch_position = ch - 'a';
                // to add or not 
                if (used[ch_position] < required[ch_position])
                {
                    //add char
                    if (ch > res[j - 1])
                    {
                        res[j++] = ch;
                        unused[ch_position]--;
                        used[ch_position]++;
                    }
                    else
                    {
                        //check bigger ele -- we re
                        //pop 

                        while (j > 0 && ch < res[j - 1] && used[res[j - 1] - 'a'] - 1 + unused[res[j - 1] - 'a'] >= required[res[j - 1] - 'a'])
                        {
                            used[res[--j] - 'a']--;
                        }
                        res[j++] = ch;
                        unused[ch_position]--;
                        used[ch_position]++;
                    }
                }
                else
                {// rejecting / discarding the perticulr char
                    unused[ch_position]--;
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                solution += res[i];
            }
            return solution;
        }
    }
}
