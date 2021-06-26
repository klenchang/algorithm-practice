using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting.Tests
{
    [TestClass()]
    public class LilysHomeworkTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var arr = new List<int> { 7, 15, 12, 3 };
            var actual = LilysHomework.Solution(arr);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var arr = new List<int> { 2, 5, 3, 1 };
            var actual = LilysHomework.Solution(arr);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var arr = new List<int> { 3, 4, 2, 5, 1 };
            var actual = LilysHomework.Solution(arr);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}