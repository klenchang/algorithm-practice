using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays.Tests
{
    [TestClass()]
    public class ArrayDynamicTests
    {
        [TestMethod()]
        public void DynamicArrayTest()
        {
            int n = 2;
            var list = new List<List<int>>
            {
                new List<int> { 1, 0, 5 },
                new List<int> { 1, 1, 7 },
                new List<int> { 1, 0, 3 },
                new List<int> { 2, 1, 0 },
                new List<int> { 2, 1, 1 },
            };
            var actual = ArrayDynamic.DynamicArray(n, list);
            var expected = new List<int> { 7, 3 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}