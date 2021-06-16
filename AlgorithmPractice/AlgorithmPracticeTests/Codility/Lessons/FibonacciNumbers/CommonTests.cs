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

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void GetFibonacciListTest_1()
        {
            var maxValue = 1;
            var actual = Common.GetFibonacciList(maxValue);
            var expected = new int[] { 0, 1, 1 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void GetFibonacciListTest_2()
        {
            var maxValue = 0;
            var actual = Common.GetFibonacciList(maxValue);
            var expected = new int[] { 0 };

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}