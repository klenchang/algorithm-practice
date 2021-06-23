using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Challenges.May4thChallenge.Tests
{
    [TestClass()]
    public class DoubleHanoiTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 2, 3, 3, 4 };
            var L = 3;
            var R = 1;
            var actual = DoubleHanoi.Solution(A, L, R);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var A = new[] { 1, 4, 5, 5 };
            var L = 6;
            var R = 4;
            var actual = DoubleHanoi.Solution(A, L, R);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var A = new[] { 5, 2, 5, 2 };
            var L = 8;
            var R = 1;
            var actual = DoubleHanoi.Solution(A, L, R);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var A = new[] { 1, 5, 5 };
            var L = 2;
            var R = 4;
            var actual = DoubleHanoi.Solution(A, L, R);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest4()
        {
            var A = new[] { 1000000000 };
            var L = 3;
            var R = 1000000000;
            var actual = DoubleHanoi.Solution(A, L, R);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}