using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    public class ColorizedNodes : IAlgorithm
    {
        public void Execute()
        {
            int[] graphFrom = { 1, 2, 2, 3 };
            int[] graphTo = { 2, 3, 4, 5 };
            long[] ids = { 1, 2, 3, 1, 3 };
            int val = 1;

            var egdes_map = new int[ids.Length];
            var egdes = new int[ids.Length];

            for (int i = 0; i < graphTo.Length; i++)
            {
                egdes_map[i] = 0;
                egdes[i] = 0;
            }


            for (int i = 0; i < graphTo.Length; i++)
            {
                //egdes[graphFrom[i]] = 
            }

            
        }

        struct Node
        {
            public int id;
            public long val;

            public Node(int id, long val)
            {
                this.id = id;
                this.val = val;
            }
        }
    }
}
