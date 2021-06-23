using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Codility.Lessons.MaximumSliceProblem;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.MaximumSliceProblem.Tests
{
    [TestClass()]
    public class MaxProfitTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            var actual = MaxProfit.Solution(array);
            var expected = 356;

            Assert.AreEqual(expected, actual);
        }
    }
}