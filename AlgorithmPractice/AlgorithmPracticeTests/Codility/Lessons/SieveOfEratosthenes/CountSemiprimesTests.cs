using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.SieveOfEratosthenes.Tests
{
    [TestClass()]
    public class CountSemiprimesTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var N = 26;
            var P = new[] { 1, 4, 16 };
            var Q = new[] { 26, 10, 20 };
            var actual = CountSemiprimes.Solution1(N, P, Q);
            var expected = new[] { 10, 4, 0 };

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}