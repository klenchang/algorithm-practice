using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.BinarySearchAlgorithm.Tests
{
    [TestClass()]
    public class NailingPlanksTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, 4, 5, 8 };
            var B = new[] { 4, 5, 9, 10 };
            var C = new[] { 4, 6, 7, 10, 2 };
            var actual = NailingPlanks.Solution(A, B, C);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }
    }
}