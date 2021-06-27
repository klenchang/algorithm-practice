using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation.Tests
{
    [TestClass()]
    public class SherlockAndTheValidStringTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var s = "abc";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "YES";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest1()
        {
            var s = "abcc";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "YES";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            var s = "abccc";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "NO";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            var s = "aabbcd";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "NO";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest4()
        {
            var s = "aabbccddeefghi";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "NO";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsValidTest5()
        {
            var s = "abcdefghhgfedecba";
            var actual = SherlockAndTheValidString.IsValid(s);
            var expected = "YES";

            Assert.AreEqual(expected, actual);
        }
    }
}