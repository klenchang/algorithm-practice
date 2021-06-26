using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Arrays.Tests
{
    [TestClass()]
    public class ArrayManipulationTests
    {
        [TestMethod()]
        public void ArrayManipulationTest()
        {
            var n = 10;
            var queries = new List<List<int>>
            {
                new List<int> { 1, 5, 3 },
                new List<int> { 4, 8, 7 },
                new List<int> { 6, 9, 1 },
            };
            var actual = ArrayManipulation.ArrayManipulationFunction(n, queries);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ArrayManipulationTest1()
        {
            var n = 10;
            var queries = new List<List<int>>
            {
                new List<int> { 1, 5, 3 },
                new List<int> { 4, 8, 7 },
                new List<int> { 6, 9, 1 },
                new List<int> { 10, 10, 1 },
            };
            var actual = ArrayManipulation.ArrayManipulationFunction(n, queries);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }
    }
}