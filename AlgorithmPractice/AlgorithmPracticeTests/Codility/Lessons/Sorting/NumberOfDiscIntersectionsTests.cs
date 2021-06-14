using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Codility.Lessons.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.Sorting.Tests
{
    [TestClass()]
    public class NumberOfDiscIntersectionsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 1, 2147483647, 0 };
            var actual = NumberOfDiscIntersections.Solution1(array);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var array = new[] { 2147483647, 2147483647, 0 };
            var actual = NumberOfDiscIntersections.Solution2(array);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }
    }
}