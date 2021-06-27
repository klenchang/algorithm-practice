using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps.Tests
{
    [TestClass()]
    public class FrequencyQueriesTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 1 },
                new List<int> { 2, 2 },
                new List<int> { 3, 2 },
                new List<int> { 1, 1 },
                new List<int> { 1, 1 },
                new List<int> { 2, 1 },
                new List<int> { 3, 2 },
            };
            var actual = FrequencyQueries.Solution(queries);
            var expected = new List<int> { 0, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 5 },
                new List<int> { 1, 6 },
                new List<int> { 3, 2 },
                new List<int> { 1, 10 },
                new List<int> { 1, 10 },
                new List<int> { 1, 6 },
                new List<int> { 2, 5 },
                new List<int> { 3, 2 },
            };
            var actual = FrequencyQueries.Solution(queries);
            var expected = new List<int> { 0, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 3, 4 },
                new List<int> { 2, 1003 },
                new List<int> { 1, 16 },
                new List<int> { 3, 1 },
            };
            var actual = FrequencyQueries.Solution(queries);
            var expected = new List<int> { 0, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 3, 2 },
                new List<int> { 1, 4 },
                new List<int> { 1, 5 },
                new List<int> { 1, 5 },
                new List<int> { 1, 4 },
                new List<int> { 3, 2 },
                new List<int> { 2, 4 },
                new List<int> { 3, 2 },
            };
            var actual = FrequencyQueries.Solution(queries);
            var expected = new List<int> { 0, 1, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest4()
        {
            var queries = new List<List<int>>
            {
                new List<int> { 2, 5 },
                new List<int> { 1, 5 },
                new List<int> { 3, 1 },
                new List<int> { 1, 6 },
                new List<int> { 3, 2 },
                new List<int> { 1, 10 },
                new List<int> { 1, 10 },
                new List<int> { 1, 6 },
                new List<int> { 2, 5 },
                new List<int> { 3, 2 },
            };
            var actual = FrequencyQueries.Solution(queries);
            var expected = new List<int> { 1, 0, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}