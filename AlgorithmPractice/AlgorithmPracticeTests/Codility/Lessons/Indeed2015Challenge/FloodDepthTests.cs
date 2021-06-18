using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2015Challenge.Tests
{
    [TestClass()]
    public class FloodDepthTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 5, 8 };
            var actual = FloodDepth.Solution(A);
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var A = new[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 };
            var actual = FloodDepth.Solution(A);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var A = new[] { 3, 1, 2 };
            var actual = FloodDepth.Solution(A);
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }
    }
}