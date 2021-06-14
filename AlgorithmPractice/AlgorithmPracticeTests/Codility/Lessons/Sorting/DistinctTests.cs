using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Codility.Lessons.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.Sorting.Tests
{
    [TestClass()]
    public class DistinctTests
    {
        [TestMethod()]
        public void SolutionTest_NormalCase()
        {
            var array = new[] { 2, 1, 1, 2, 3, 1 };
            var actual = Distinct.Solution(array);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_EmptyArray()
        {
            var array = new int[] { };
            var actual = Distinct.Solution(array);
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_OneElementArray()
        {
            var array = new int[] { -1000 };
            var actual = Distinct.Solution(array);
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}