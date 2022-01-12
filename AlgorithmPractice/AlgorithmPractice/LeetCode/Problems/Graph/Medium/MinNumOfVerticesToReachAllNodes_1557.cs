using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium
{
    public class MinNumOfVerticesToReachAllNodes_1557
    {
        #region topic
        /*
         give a graph, find the minimum number of vertices to reach all nodes.
         It's guaranteed that a unique solution exists.
         
        ex.
         intput: n = 6, edges = [[0,1],[0,2],[2,5],[3,4],[4,2]]
         output: [0, 3]
         explain:
            0 -> 1, 2
            2 -> 5
            3 -> 4
            4 -> 2
         it cannot reach all nodes from one node. It needs 0 and 3.

        Constraints:
            2 <= n <= 10^5
            1 <= edges.length <= min(10^5, n * (n - 1) / 2)
            edges[i].length == 2
            0 <= fromi, toi < n
            All pairs (fromi, toi) are distinct.

        copy@right:https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
         */
        #endregion

        public static IList<int> FindSmallestSetOfVertices(int n, List<List<int>> edges)
        {
            // visited illustrate which node could be visited from other node
            var visited = new bool[n];
            foreach (var e in edges)
                visited[e[1]] = true;

            var result = new List<int>();
            for (int i = 0; i < visited.Length; i++)
            {
                // if one node cannot be visited, if means it only can be visited by itself.
                // so the result must need to include it.
                if (!visited[i])
                    result.Add(i);
            }
            return result;
        }
    }
}
