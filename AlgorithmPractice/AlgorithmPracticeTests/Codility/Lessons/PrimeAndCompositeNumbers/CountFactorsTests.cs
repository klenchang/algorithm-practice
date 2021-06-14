using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrimeAndCompositeNumbers.Tests
{
    [TestClass()]
    public class CountFactorsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var N = 24;
            var actual = CountFactors.Solution(N);
            var expected = 8;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var N = 16;
            var actual = CountFactors.Solution(N);
            var expected = 5;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var N = 1;
            var actual = CountFactors.Solution(N);
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}