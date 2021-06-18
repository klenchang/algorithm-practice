using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class MaxNonoverlappingSegmentsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, 3, 7, 9, 9 };
            var B = new[] { 5, 6, 8, 9, 10 };
            var actual = MaxNonoverlappingSegments.Solution(A, B);
            var expected = 3;

            Assert.AreEqual(actual, expected);
        }
    }
}