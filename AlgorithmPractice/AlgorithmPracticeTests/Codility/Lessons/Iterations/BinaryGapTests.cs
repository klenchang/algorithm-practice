using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Iterations.Tests
{
    [TestClass()]
    public class BinaryGapTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            int N = 1041;
            var actual = BinaryGap.Solution(N);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            int N = 32;
            var actual = BinaryGap.Solution(N);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}