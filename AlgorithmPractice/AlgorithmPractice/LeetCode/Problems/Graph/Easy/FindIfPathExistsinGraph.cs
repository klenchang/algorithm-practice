using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Easy
{
    public class FindIfPathExistsinGraph
    {
        #region topic
        /*
        There is a bi-directional graph with n vertices, 
        where each vertex is labeled from 0 to n - 1 (inclusive). 
        The edges in the graph are represented as a 2D integer array edges, 
        where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui 
        and vertex vi. Every vertex pair is connected by at most one edge, 
        and no vertex has an edge to itself.

        You want to determine if there is a valid path that exists from vertex 
        start to vertex end.

        Given edges and the integers n, start, and end, return true 
        if there is a valid path from start to end, or false otherwise. 

        Input: n = 3, edges = [[0,1],[1,2],[2,0]], start = 0, end = 2
        Output: true
        Explanation: There are two paths from vertex 0 to vertex 2:
        - 0 → 1 → 2
        - 0 → 2

        Input: n = 6, edges = [[0,1],[0,2],[3,5],[5,4],[4,3]], start = 0, end = 5
        Output: false
        Explanation: There is no path from vertex 0 to vertex 5.

        Constraints:
            1 <= n <= 2 * 105
            0 <= edges.length <= 2 * 105
            edges[i].length == 2
            0 <= ui, vi <= n - 1
            ui != vi
            0 <= start, end <= n - 1
            There are no duplicate edges.
            There are no self edges.

        copy@right: https://leetcode.com/problems/find-if-path-exists-in-graph/
         */
        #endregion

        public class SolutionWithDFSRecursive
        {
            public static bool ValidPath(int n, int[][] edges, int start, int end)
            {
                var map = BuildMap(n, edges);
                var visited = new HashSet<int>();
                DFS(map, visited, start, n);

                return visited.Contains(end);
            }
            private static void DFS(bool[,] map, HashSet<int> visited, int row, int n)
            {
                if (!visited.Contains(row))
                {
                    visited.Add(row);
                    for (int i = 0; i < n; i++)
                    {
                        if (map[row, i])
                            DFS(map, visited, i, n);
                    }
                }
            }
            private static bool[,] BuildMap(int n, int[][] edges)
            {
                var map = new bool[n, n];
                foreach (var e in edges)
                {
                    map[e[0], e[1]] = true;
                    map[e[1], e[0]] = true;
                }
                return map;
            }
        }

        public class SolutionWithHashMap
        {
            public static bool ValidPath(int n, int[][] edges, int start, int end)
            {
                var map = BuildMap(edges);
                var visited = new HashSet<int>();
                var queue = new Queue<int>();
                queue.Enqueue(start);
                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    if (map.ContainsKey(current))
                    {
                        var destinations = map[current];
                        foreach(var d in destinations)
                            if (!visited.Contains(d))
                                queue.Enqueue(d);
                    }
                    visited.Add(current);
                    if (current == end)
                        return true;
                }

                return false;
            }
            private static Dictionary<int, HashSet<int>> BuildMap(int[][] edges)
            {
                var map = new Dictionary<int, HashSet<int>>();
                for (int x = 0; x < edges.Length; x++)
                {
                    var p1 = edges[x][0];
                    var p2 = edges[x][1];
                    AddRowToMap(map, p1, p2);
                    AddRowToMap(map, p2, p1);
                }

                return map;
            }
            private static void AddRowToMap(Dictionary<int, HashSet<int>> map, int p1, int p2)
            {
                if (map.ContainsKey(p1))
                    map[p1].Add(p2);
                else
                    map.Add(p1, new HashSet<int> { p2 });
            }
        }
    }
}
