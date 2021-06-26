using AlgorithmPractice.Hackerrank.Interview.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting.Tests
{
    [TestClass()]
    public class FraudulentActivityNotificationsTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            var list = new List<int> { 10, 20, 30, 40, 50 };
            var d = 3;
            var actual = FraudulentActivityNotifications.Solution1(list, d);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var list = new List<int> { 10, 20, 30, 40, 50 };
            var d = 3;
            var actual = FraudulentActivityNotifications.Solution2(list, d);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMidTest()
        {
            var counts = new[] { 0, 1, 1, 1, 1, 1 };
            var d = 5;
            var actual = FraudulentActivityNotifications.GetMid(counts, d);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMidTest1()
        {
            var counts = new[] { 0, 1, 1, 1, 1 };
            var d = 4;
            var actual = FraudulentActivityNotifications.GetMid(counts, d);
            var expected = 2.5m;

            Assert.AreEqual(expected, actual);
        }
    }
}