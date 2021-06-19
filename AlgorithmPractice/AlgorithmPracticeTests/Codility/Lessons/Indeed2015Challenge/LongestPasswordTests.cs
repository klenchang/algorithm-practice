using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2015Challenge.Tests
{
    [TestClass()]
    public class LongestPasswordTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var S = "test 5 a0A pass007 ?xy1";
            var actual = LongestPassword.Solution(S);
            var expected = 7;

            Assert.AreEqual(actual, expected);
        }
    }
}