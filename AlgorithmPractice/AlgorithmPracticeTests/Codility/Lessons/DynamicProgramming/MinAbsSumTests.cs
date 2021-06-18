using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.DynamicProgramming.Tests
{
    [TestClass()]
    public class MinAbsSumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, 5, 2, -2 };
            var actual = MinAbsSum.Solution(A);
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }
    }
}