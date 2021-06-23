using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.BinarySearchAlgorithm.Tests
{
    [TestClass()]
    public class MinMaxDivisionTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var K = 3;
            var M = 5;
            var array = new[] { 2, 1, 5, 1, 2, 2, 2 };
            var actual = MinMaxDivision.Solution(K, M, array);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}