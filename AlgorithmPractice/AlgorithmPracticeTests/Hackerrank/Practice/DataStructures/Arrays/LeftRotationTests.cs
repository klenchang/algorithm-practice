using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays.Tests
{
    [TestClass()]
    public class LeftRotationTests
    {
        [TestMethod()]
        public void RotateLeftTest()
        {
            var d = 4;
            var arr = new List<int> { 1, 2, 3, 4, 5 };
            var actual = LeftRotation.RotateLeft(d, arr);
            var expected = new List<int> { 5, 1, 2, 3, 4 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}