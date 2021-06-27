using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation.Tests
{
    [TestClass()]
    public class SpecialStringAgainTests
    {
        [TestMethod()]
        public void SubstrCountTest()
        {
            var n = 8;
            var s = "mnonopoo";
            var actual = SpecialStringAgain.SubstrCount(n, s);
            var expected = 12;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstrCountTest1()
        {
            var n = 5;
            var s = "asasd";
            var actual = SpecialStringAgain.SubstrCount(n, s);
            var expected = 7;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstrCountTest2()
        {
            var n = 7;
            var s = "abcbaba";
            var actual = SpecialStringAgain.SubstrCount(n, s);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstrCountTest3()
        {
            var n = 4;
            var s = "aaaa";
            var actual = SpecialStringAgain.SubstrCount(n, s);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstrCountTest4()
        {
            var s = "ccacacabccacabaaaabbc";
            var n = s.Length;
            var actual = SpecialStringAgain.SubstrCount(n, s);
            var expected = 37;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstrCount2Test()
        {
            var s = "ccacacabccacabaaaabbc";
            var n = s.Length;
            var actual = SpecialStringAgain.SubstrCount2(n, s);
            var expected = 37;

            Assert.AreEqual(expected, actual);
        }
    }
}