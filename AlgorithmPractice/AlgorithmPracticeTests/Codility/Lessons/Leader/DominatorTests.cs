using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.Leader.Tests
{
    [TestClass()]
    public class DominatorTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 3, 4, 3, 2, 3, -1, 3, 3 };
            var actual = Dominator.Solution(array);
            var validList = new[] { 0, 2, 4, 6, 7 };

            Assert.IsTrue(validList.Contains(actual));
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { 2, 1, 1, 1, 3 };
            var actual = Dominator.Solution(array);
            var validList = new[] { 1, 2, 3 };

            Assert.IsTrue(validList.Contains(actual));
        }
    }
}