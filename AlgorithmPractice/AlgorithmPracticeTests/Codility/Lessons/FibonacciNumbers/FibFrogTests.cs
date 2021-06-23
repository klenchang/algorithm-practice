using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers.Tests
{
    [TestClass()]
    public class FibFrogTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };
            var actual = FibFrog.Solution(array);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_1()
        {
            var array = new[] { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            var actual = FibFrog.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new int[0];
            var actual = FibFrog.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var array = new int[] { 0, 0, 0 };
            var actual = FibFrog.Solution(array);
            var expected = -1;

            Assert.AreEqual(expected, actual);
        }
    }
}