using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.Arrays.Tests
{
    [TestClass()]
    public class MinimumSwapsTests
    {
        [TestMethod()]
        public void MinimumSwapTest()
        {
            var arr = new[] { 7, 1, 3, 2, 4, 5, 6 };
            var actual = MinimumSwaps.MinimumSwap(arr);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumSwapTest1()
        {
            var arr = new[] { 4, 3, 1, 2 };
            var actual = MinimumSwaps.MinimumSwap(arr);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumSwapTest2()
        {
            var arr = new[] { 2, 3, 4, 1, 5 };
            var actual = MinimumSwaps.MinimumSwap(arr);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumSwapTest3()
        {
            var arr = new[] { 1, 3, 5, 2, 4, 6, 7 };
            var actual = MinimumSwaps.MinimumSwap(arr);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}