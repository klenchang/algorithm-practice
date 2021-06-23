using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod.Tests
{
    [TestClass()]
    public class MinAbsSumOfTwoTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, 4, -3 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_1()
        {
            var A = new[] { -8, 4, 5, -10, 3 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var A = new[] { -10, -1, 7 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var A = new[] { -1000000000, -1000000000, -1000000000 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 2000000000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_4()
        {
            var A = new[] { 999999998, 999999999, 1000000000 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 1999999996;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_5()
        {
            var A = new[] { -999999998, -999999996, 0, 999999995, 999999997, 1000000000 };
            var actual = MinAbsSumOfTwo.Solution(A);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}