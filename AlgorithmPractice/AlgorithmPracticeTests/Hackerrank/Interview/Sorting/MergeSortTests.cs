using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting.Tests
{
    [TestClass()]
    public class MergeSortTests
    {
        [TestMethod()]
        public void CountInversionsTest()
        {
            var arr = new List<int> { 2, 4, 1 };
            var actual = MergeSort.CountInversions(arr);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountInversionsTest1()
        {
            var arr = new List<int> { 1, 1, 1, 2, 2 };
            var actual = MergeSort.CountInversions(arr);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountInversionsTest2()
        {
            var arr = new List<int> { 2, 1, 3, 1, 2 };
            var actual = MergeSort.CountInversions(arr);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountInversionsTest3()
        {
            var arr = new List<int> { 7, 5, 3, 1 };
            var actual = MergeSort.CountInversions(arr);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}