using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree.Tests
{
    [TestClass()]
    public class SwapNodesTests
    {
        [TestMethod()]
        public void SwapTest()
        {
            var indexes = new List<List<int>>
            {
                new List<int> { 2, 3 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 }
            };
            var queries = new List<int> { 1, 1 };
            var actual = SwapNodes.Swap(indexes, queries);
            var expected = new List<List<int>>
            {
                new List<int> { 3, 1, 2 },
                new List<int> { 2, 1, 3 }
            };
            Assert.AreEqual(expected.Count, actual.Count);
            for (int index = 0; index < expected.Count; index++)
                CollectionAssert.AreEqual(expected[index], actual[index]);
        }

        [TestMethod()]
        public void SwapTest2()
        {
            var indexes = new List<List<int>>
            {
                new List<int> { 2, 3 },
                new List<int> { 4, 5 },
                new List<int> { 6, -1 },
                new List<int> { -1, 7 },
                new List<int> { 8, 9 },
                new List<int> { 10, 11 },
                new List<int> { 12, 13 },
                new List<int> { -1, 14 },
                new List<int> { -1, -1 },
                new List<int> { 15, -1 },
                new List<int> { 16, 17 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 }
            };
            var queries = new List<int> { 2, 3 };
            var actual = SwapNodes.Swap(indexes, queries);
            var expected = new List<List<int>>
            {
                new List<int> { 14, 8, 5, 9, 2, 4, 13, 7, 12, 1, 3, 10, 15, 6, 17, 11, 16 },
                new List<int> { 9, 5, 14, 8, 2, 13, 7, 12, 4, 1, 3, 17, 11, 16, 6, 10, 15 }
            };
            Assert.AreEqual(expected.Count, actual.Count);
            for (int index = 0; index < expected.Count; index++)
                CollectionAssert.AreEqual(expected[index], actual[index]);
        }

        [TestMethod()]
        public void SwapTest3()
        {
            var indexes = new List<List<int>>
            {
                new List<int> { 2, 3 },
                new List<int> { 4, -1 },
                new List<int> { 5, -1 },
                new List<int> { 6, -1 },
                new List<int> { 7, 8 },
                new List<int> { -1, 9 },
                new List<int> { -1, -1 },
                new List<int> { 10, 11 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 },
                new List<int> { -1, -1 }
            };
            var queries = new List<int> { 2, 4 };
            var actual = SwapNodes.Swap(indexes, queries);
            var expected = new List<List<int>>
            {
                new List<int> { 2, 9, 6, 4, 1, 3, 7, 5, 11, 8, 10 },
                new List<int> { 2, 6, 9, 4, 1, 3, 7, 5, 10, 8, 11 }
            };
            Assert.AreEqual(expected.Count, actual.Count);
            for (int index = 0; index < expected.Count; index++)
                CollectionAssert.AreEqual(expected[index], actual[index]);
        }
    }
}