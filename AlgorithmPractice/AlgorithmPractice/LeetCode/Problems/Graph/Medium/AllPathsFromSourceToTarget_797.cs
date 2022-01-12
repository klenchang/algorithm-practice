using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium
{
    public class AllPathsFromSourceToTarget_797
    {
        #region topic
        /*
         Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, 
         find all possible paths from node 0 to node n - 1 and return them in any order.

         The graph is given as follows: graph[i] is a list of all nodes you can visit from node 
         i (i.e., there is a directed edge from node i to node graph[i][j]). 
         
         Input: graph = [[1,2],[3],[3],[]]
         Output: [[0,1,3],[0,2,3]]
         Explanation: 
            0 -> 1, 2
            1 -> 3
            2 -> 3
            3 -> null
            There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.

         Constraints:
            n == graph.length
            2 <= n <= 15
            0 <= graph[i][j] < n
            graph[i][j] != i (i.e., there will be no self-loops).
            All the elements of graph[i] are unique.
            The input graph is guaranteed to be a DAG.
         
         copy@right: https://leetcode.com/problems/all-paths-from-source-to-target/
         */
        #endregion

        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var result = new List<IList<int>>();
            Traverse(0, new List<int>() { 0 }, graph, result);
            return result;
        }
        private static void Traverse(int i, List<int> current, int[][] graph, IList<IList<int>> result)
        {
            if (i == graph.Length - 1)
            {
                // must need to use ToList() to do deep copy
                result.Add(current.ToList());
                return;
            }

            foreach (var j in graph[i])
            {
                // to avoid infinite loop, assume node only can be visited once
                if (!current.Contains(j))
                {
                    current.Add(j);
                    Traverse(j, current, graph, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
