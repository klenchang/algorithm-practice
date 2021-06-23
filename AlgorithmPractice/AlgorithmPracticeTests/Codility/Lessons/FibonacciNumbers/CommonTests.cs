using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers.Tests
{
    [TestClass()]
    public class CommonTests
    {
        [TestMethod()]
        public void GetFibonacciListTest()
        {
            var maxValue = 13;
            var actual = Common.GetFibonacciList(maxValue);
            var expected = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFibonacciListTest_1()
        {
            var maxValue = 1;
            var actual = Common.GetFibonacciList(maxValue);
            var expected = new int[] { 0, 1, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFibonacciListTest_2()
        {
            var maxValue = 0;
            var actual = Common.GetFibonacciList(maxValue);
            var expected = new int[] { 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFibonacciListBaseOnNTest()
        {
            var n = 5;
            var actual = Common.GetFibonacciListBaseOnN(n);
            var expected = new int[] { 0, 1, 1, 2, 3, 5 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}