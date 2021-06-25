using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays.Tests
{
    [TestClass()]
    public class Array2DTests
    {
        [TestMethod()]
        public void HourglassSumTest()
        {
            var arr = new List<List<int>>
            {
                new List<int> { 1, 1, 1, 0, 0, 0 },
                new List<int> { 0, 1, 0, 0, 0, 0 },
                new List<int> { 1, 1, 1, 0, 0, 0 },
                new List<int> { 0, 0, 2, 4, 4, 0 },
                new List<int> { 0, 0, 0, 2, 0, 0 },
                new List<int> { 0, 0, 1, 2, 4, 0 },
            };
            var actual = Array2D.HourglassSum(arr);
            var expected = 19;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HourglassSumTest1()
        {
            var arr = new List<List<int>>
            {
                new List<int> { 1, 1, 1, 0, 0, 0 },
                new List<int> { 0, 1, 0, 0, 0, 0 },
                new List<int> { 1, 1, 1, 0, 0, 0 },
            };
            var actual = Array2D.HourglassSum(arr);
            var expected = 7;

            Assert.AreEqual(expected, actual);
        }
    }
}