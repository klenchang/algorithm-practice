using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class TieRopesTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var K = 4;
            var A = new[] { 1, 2, 3, 4, 1, 1, 3 };
            var actual = TieRopes.Solution(K, A);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var K = 5;
            var A = new[] { 1, 2, 3, 4, 1, 1, 3 };
            var actual = TieRopes.Solution(K, A);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }
    }
}