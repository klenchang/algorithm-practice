using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrimeAndCompositeNumbers.Tests
{
    [TestClass()]
    public class MinPerimeterRectangleTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var N = 30;
            var actual = MinPerimeterRectangle.Solution(N);
            var expected = 22;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var N = 64;
            var actual = MinPerimeterRectangle.Solution(N);
            var expected = 32;

            Assert.AreEqual(actual, expected);
        }
    }
}