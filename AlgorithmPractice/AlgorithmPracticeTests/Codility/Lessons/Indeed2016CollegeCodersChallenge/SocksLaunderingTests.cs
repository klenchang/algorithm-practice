using AlgorithmPractice.Codility.Lessons.Indeed2016CollegeCodersChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2016CollegeCodersChallenge.Tests
{
    [TestClass()]
    public class SocksLaunderingTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            int K = 2;
            var C = new[] { 1, 2, 1, 1 };
            var D = new[] { 1, 4, 3, 2, 4 };
            var actual = SocksLaundering.Solution(K, C, D);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {

            int K = 2;
            var C = new[] { 1, 1, 50, 50 };
            var D = new[] { 1, 4, 3, 2, 50 };
            var actual = SocksLaundering.Solution(K, C, D);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}