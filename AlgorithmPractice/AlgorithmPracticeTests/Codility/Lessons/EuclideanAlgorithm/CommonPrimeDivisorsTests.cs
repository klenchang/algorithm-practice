using AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm.Tests
{
    [TestClass()]
    public class CommonPrimeDivisorsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 15, 10, 3 };
            var B = new[] { 75, 30, 5 };
            var actual = CommonPrimeDivisors.Solution(A, B);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckPrimesASameWithBTest()
        {
            var n = 15;
            var m = 75;
            var actual = CommonPrimeDivisors.CheckPrimesOfASameWithB(n, m);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckPrimesASameWithBTest_2()
        {
            var n = 30;
            var m = 10;
            var actual = CommonPrimeDivisors.CheckPrimesOfASameWithB(n, m);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckPrimesSameWithGCDTest()
        {
            var n = 75;
            var gcd = 15;
            var actual = CommonPrimeDivisors.CheckPrimesSameWithGCD(n, gcd);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckPrimesSameWithGCDTest_2()
        {
            var n = 30;
            var gcd = 10;
            var actual = CommonPrimeDivisors.CheckPrimesSameWithGCD(n, gcd);

            Assert.IsFalse(actual);
        }
    }
}