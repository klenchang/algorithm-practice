﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm.Tests
{
    [TestClass()]
    public class ChocolatesByNumbersTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var N = 10;
            var M = 4;
            var actual = ChocolatesByNumbers.Solution(N, M);
            var expected = 5;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var N = 947853;
            var M = 4453;
            var actual = ChocolatesByNumbers.Solution(N, M);
            var expected = 947853;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void GCDTest()
        {
            var N = 16;
            var M = 12;
            var actual = ChocolatesByNumbers.GCD(N, M);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }
    }
}