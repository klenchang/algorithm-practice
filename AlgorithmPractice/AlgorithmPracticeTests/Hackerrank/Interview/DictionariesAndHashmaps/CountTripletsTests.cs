using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps.Tests
{
    [TestClass()]
    public class CountTripletsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var arr = new List<long> { 1, 4, 16, 64 };
            long r = 4;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var arr = new List<long> { 1, 2, 2, 4 };
            long r = 2;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var arr = new List<long> { 1, 3, 9, 9, 27, 81 };
            long r = 3;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var arr = new List<long> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            long r = 1;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 161700;

            Assert.AreEqual(expected, actual);
        }

        public void SolutionTest4()
        {
            var arr = new List<long> { 1, 17, 5, 5, 58, 17, 70, 16, 35, 71, 16, 32, 2 };
            long r = 2;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest5()
        {
            var arr = new List<long> { 3, 15, 5, 45 };
            long r = 3;
            var actual = CountTriplets.Solution(arr, r);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}