using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays.Tests
{
    [TestClass()]
    public class ArraysTests
    {
        [TestMethod()]
        public void ReverseArrayTest()
        {
            var a = new List<int> { 1, 4, 3, 2 };
            var actual = Arrays.ReverseArray(a);
            var expected = new List<int> { 2, 3, 4, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}