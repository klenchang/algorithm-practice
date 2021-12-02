using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.CustomizedPractice.Search.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void UseBinarySearchToFindTargetIndexInSortedArrayWithEvenElements()
        {
            var array = new[] { 1, 3, 5, 6, 7, 9 };
            var actual = BinarySearch.Search(array, 5);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UseBinarySearchToFindTargetIndexInSortedArrayWithOddElements()
        {
            var array = new[] { -1, 1, 3, 5, 6, 7, 9 };
            var actual = BinarySearch.Search(array, 7);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}