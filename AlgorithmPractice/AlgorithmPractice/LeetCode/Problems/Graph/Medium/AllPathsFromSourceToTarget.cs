using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium
{
    public class AllPathsFromSourceToTarget
    {
        #region topic
        /*
         Input: graph = [[1,2],[3],[3],[]]
         Output: [[0,1,3],[0,2,3]]
         Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.
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
                result.Add(current.ToList());
                return;
            }

            foreach (var j in graph[i])
            {
                current.Add(j);
                Traverse(j, current, graph, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
