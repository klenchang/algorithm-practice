using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmPractice.CustomizedPractice.Sorting.Tests
{
    [TestClass()]
    public class HeapSortTests
    {
        [TestMethod()]
        public void GivenIntArrayToTestHeapSort()
        {
            var array = new[] { 1, 5, 6, 3, 9, 7, 5, 6, 10, 99, 100, -1, -2, 5 };
            var actual = HeapSort.Sort(array);
            Array.Sort(array);

            CollectionAssert.AreEqual(array, actual);
        }
    }
}