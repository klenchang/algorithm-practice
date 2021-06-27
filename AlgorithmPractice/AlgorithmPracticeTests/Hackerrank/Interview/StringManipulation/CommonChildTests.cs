using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation.Tests
{
    [TestClass()]
    public class CommonChildTests
    {
        [TestMethod()]
        public void CommonChildTest()
        {
            var s1 = "ABCD";
            var s2 = "ABDC";
            var actual = CommonChild.Solution(s1, s2);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CommonChildTest1()
        {
            var s1 = "HARRY";
            var s2 = "SALLY";
            var actual = CommonChild.Solution(s1, s2);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CommonChildTest2()
        {
            var s1 = "AA";
            var s2 = "BB";
            var actual = CommonChild.Solution(s1, s2);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CommonChildTest3()
        {
            var s1 = "SHINCHAN";
            var s2 = "NOHARAAA";
            var actual = CommonChild.Solution(s1, s2);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CommonChildTest4()
        {
            var s1 = "ABCDEF";
            var s2 = "FBDAMN";
            var actual = CommonChild.Solution(s1, s2);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}