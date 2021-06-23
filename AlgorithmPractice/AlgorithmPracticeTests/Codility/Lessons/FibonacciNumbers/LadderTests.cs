using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers.Tests
{
    [TestClass()]
    public class LadderTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var arrayA = new int[] { 4, 4, 5, 5, 1 };
            var arrayB = new int[] { 3, 2, 4, 3, 1 };
            var actual = Ladder.Solution(arrayA, arrayB);
            var expected = new[] { 5, 1, 8, 0, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}