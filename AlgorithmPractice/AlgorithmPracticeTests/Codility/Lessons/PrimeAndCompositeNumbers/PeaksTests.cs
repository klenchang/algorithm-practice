using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrimeAndCompositeNumbers.Tests
{
    [TestClass()]
    public class PeaksTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            var actual = Peaks.Solution(array);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            var actual = Peaks.Solution(array);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }
    }
}