using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graph
{
    public class RoadsAndLibraries : IAlgorithm
    {
        public void Execute()
        {
           int n = 3;
           int m = 3;
           int c_lib = 2;
           int c_road = 1;
           var cities = new List<List<int>> {
               new List<int> { 1, 2 },
               new List<int> { 3, 1},
               new List<int> { 2, 3 }
           };
           // Algorithm implementation
           long totalCost = roadsAndLibraries(n, c_lib, c_road, cities);
           Console.WriteLine($"Resulet = {totalCost}");

        }

        // Find connected components and do calculation acording that
        public static long roadsAndLibraries(int n, int c_lib, int c_road, List<List<int>> cities)
        {
            // init graph boilerplate
            List<long>[] graph = new List<long>[n + 1];
            for(int i = 0; i < graph.Length; i++)
                graph[i] = new List<long>();
            
            var visited = new long[n + 1];
            var components = new List<long>();
            // build undirected graph
            for (int i = 0; i < cities.Count; i++)
            {
                graph[cities[i][1]].Add(cities[i][0]);
                graph[cities[i][0]].Add(cities[i][1]);
            }

            for (int i = 1; i <= n; i++)
            {
                if (graph[i].Count > 0 && visited[i] == 0)
                    components.Add(dfs(i, visited, graph));
                else if (graph[i].Count == 0)
                    components.Add(1);
            }
            long res = 0;
            foreach (var comp in components)
            {
                long tmp = (comp - 1) * c_road + c_lib;
                res += Math.Min(tmp, comp * c_lib);
            }

            return res;

        }

        // basic DFS algorithm
        private static long dfs(long current, long[] visited, List<long>[] graph)
        {
            long weight = 1;
            visited[current]++;

            for (int i = 0; i < graph[current].Count; ++i)
            {
                if (visited[graph[current][i]] == 0)
                {
                    visited[graph[current][i]]++;
                    weight += dfs(visited[graph[current][i]], visited, graph);
                }
            }
            return weight;
        }
    }
}
