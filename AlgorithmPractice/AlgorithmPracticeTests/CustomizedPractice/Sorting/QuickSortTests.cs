using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.CustomizedPractice.Sorting.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void GiveIntArrayToTestQuickSort()
        {
            var array = new[] { 1, 5, 6, 3, 9, 7, 5, 6 };
            var actual = QuickSort.Sort(array);
            var expected = new[] { 1, 3, 5, 5, 6, 6, 7, 9 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}