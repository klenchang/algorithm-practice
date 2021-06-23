using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CountingElements.Tests
{
    [TestClass()]
    public class MissingIntegerTests
    {
        [TestMethod()]
        public void Solution2Test()
        {
            var A = new[] { 1, 3, 6, 4, 1, 2 };
            var actual = MissingInteger.Solution2(A);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test1()
        {
            var A = new[] { -1000000, 1, 3, 6, 4, 1, 2, 1000000 };
            var actual = MissingInteger.Solution2(A);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}