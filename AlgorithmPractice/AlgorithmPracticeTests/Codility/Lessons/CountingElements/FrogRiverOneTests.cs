using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CountingElements.Tests
{
    [TestClass()]
    public class FrogRiverOneTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var X = 5;
            var A = new[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var actual = FrogRiverOne.Solution(X, A);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var X = 5;
            var A = new[] { 2, 3, 1, 4, 1, 3, 5, 4 };
            var actual = FrogRiverOne.Solution2(X, A);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}