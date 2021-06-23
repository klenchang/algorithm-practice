using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.DynamicProgramming.Tests
{
    [TestClass()]
    public class NumberSolitaireTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, -2, 0, 9, -1, -2 };
            var actual = NumberSolitaire.Solution(A);
            var expected = 8;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var A = new[] { 1, -1, -2, -3, -4, -5, -6, -7, -9, -9, -9, -9 };
            var actual = NumberSolitaire.Solution(A);
            var expected = -13;

            Assert.AreEqual(expected, actual);
        }
    }
}