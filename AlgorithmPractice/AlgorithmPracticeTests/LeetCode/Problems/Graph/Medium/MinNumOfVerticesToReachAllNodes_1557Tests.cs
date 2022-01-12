using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium.Tests
{
    [TestClass()]
    public class MinNumOfVerticesToReachAllNodes_1557Tests
    {
        [TestMethod()]
        public void FindSmallestSetOfVerticesTest()
        {
            int n = 6;
            var edges = new List<List<int>>();
            edges.Add(new List<int> { 0, 1 });
            edges.Add(new List<int> { 0, 2 });
            edges.Add(new List<int> { 2, 5 });
            edges.Add(new List<int> { 3, 4 });
            edges.Add(new List<int> { 4, 2 });

            var actual = MinNumOfVerticesToReachAllNodes_1557.FindSmallestSetOfVertices(n, edges).ToList();
            var expected = new List<int> { 0, 3 };

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}