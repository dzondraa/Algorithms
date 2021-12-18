using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStrauctures.HashMapAndDictionary
{
    public class RansomNote : IAlgorithm
    {
        public void Execute()
        {
            // Simply use mapMagazine HashMap (Dictionary) for words count.
            // If there is no enough words to create a note. Write "No"
            // Otherwise "Yes"

            // *** GIVEN INPUT
            var magazine = new List<string> { "give", "me", "one", "grand", "today", "night" };
            var note = new List<string> { "give", "one", "grand", "today" };

            Dictionary<string, int> mapMagazine = new Dictionary<string, int>();

            foreach (string str in magazine)
            {
                if (mapMagazine.ContainsKey(str)) mapMagazine[str]++;
                else mapMagazine.Add(str, 1);
            }

            foreach (string str in note)
            {
                if (!mapMagazine.ContainsKey(str))
                {
                    Console.WriteLine("No");
                    return;
                }
                if (--mapMagazine[str] == -1)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
