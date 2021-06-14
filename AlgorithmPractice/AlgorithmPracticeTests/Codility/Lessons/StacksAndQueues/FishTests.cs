using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice.Codility.Lessons.StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues.Tests
{
    [TestClass()]
    public class FishTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var arrayA = new[] { 4, 3, 2, 1, 5 };
            var arrayB = new[] { 0, 1, 0, 0, 0 };
            var actual = Fish.Solution(arrayA, arrayB);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_ContinuousTwoDown()
        {
            var arrayA = new[] { 4, 1000000001, 2, 1, 5, 10, 1000000002, 3 };
            var arrayB = new[] { 0, 1, 1, 0, 0, 1, 0, 0 };
            var actual = Fish.Solution(arrayA, arrayB);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }
    }
}