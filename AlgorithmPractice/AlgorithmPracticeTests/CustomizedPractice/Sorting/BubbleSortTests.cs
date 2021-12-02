using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmPractice.CustomizedPractice.Sorting.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void GivenIntArrayToTestBubbleSort()
        {
            var array = new[] { 1, 5, 6, 3, 9, 7, 5, 6, 10, 99, 100, -1, -2, 5 };
            var actual = BubbleSort.Sort(array);
            Array.Sort(array);

            CollectionAssert.AreEqual(array, actual);
        }
    }
}