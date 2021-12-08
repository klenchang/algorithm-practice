using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium.Tests
{
    [TestClass()]
    public class AllPathsFromSourceToTargetTests
    {
        [TestMethod()]
        public void AllPathsSourceTargetTest()
        {
            var graph = new int[][] { new[] { 1, 2 }, new[] { 3 }, new[] { 3 }, null };
            var actual = AllPathsFromSourceToTarget.AllPathsSourceTarget(graph);
            var expected = new List<List<int>> { new List<int> { 0, 1, 3 }, new List<int> { 0, 2, 3 } };

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], (List<int>)actual[i]);
            }
        }
    }
}