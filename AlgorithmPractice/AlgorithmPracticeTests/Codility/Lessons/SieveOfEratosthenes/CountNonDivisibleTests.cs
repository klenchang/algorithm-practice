using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.SieveOfEratosthenes.Tests
{
    [TestClass()]
    public class CountNonDivisibleTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 3, 1, 2, 3, 6 };
            var actual = CountNonDivisible.Solution(array);
            var expected = new[] { 2, 4, 3, 2, 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { 1, 2, 4, 8, 16 };
            var actual = CountNonDivisible.Solution(array);
            var expected = new[] { 4, 3, 2, 1, 0 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}