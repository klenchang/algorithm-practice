using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps.Tests
{
    [TestClass()]
    public class SherlockandAnagramsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var s = "mom";
            var actual = SherlockandAnagrams.Solution(s);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var s = "abba";
            var actual = SherlockandAnagrams.Solution(s);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var s = "ifailuhkqq";
            var actual = SherlockandAnagrams.Solution(s);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var s = "kkkk";
            var actual = SherlockandAnagrams.Solution(s);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest4()
        {
            var s = "cdcd";
            var actual = SherlockandAnagrams.Solution(s);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}