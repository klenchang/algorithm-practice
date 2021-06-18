using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod.Tests
{
    [TestClass()]
    public class CountTrianglesTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 10, 2, 5, 1, 8, 12 };
            var actual = CountTriangles.Solution(A);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var A = new[] { 1, 3, 5, 7, 9, 11 };
            var actual = CountTriangles.Solution(A);
            var expected = 7;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var A = new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 };
            var actual = CountTriangles.Solution(A);
            var expected = 10;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var A = new[] { 10, 2, 5, 1, 8, 12 };
            var actual = CountTriangles.Solution2(A);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution2Test_2()
        {
            var A = new[] { 1, 3, 5, 7, 9, 11 };
            var actual = CountTriangles.Solution2(A);
            var expected = 7;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution2Test_3()
        {
            var A = new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 };
            var actual = CountTriangles.Solution2(A);
            var expected = 10;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution3Test()
        {
            var A = new[] { 10, 2, 5, 1, 8, 12 };
            var actual = CountTriangles.Solution3(A);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution3Test_2()
        {
            var A = new[] { 1, 3, 5, 7, 9, 11 };
            var actual = CountTriangles.Solution3(A);
            var expected = 7;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Solution3Test_3()
        {
            var A = new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 };
            var actual = CountTriangles.Solution3(A);
            var expected = 10;

            Assert.AreEqual(actual, expected);
        }
    }
}