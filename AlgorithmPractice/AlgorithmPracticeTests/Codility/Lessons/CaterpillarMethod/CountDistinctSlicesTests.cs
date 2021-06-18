using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod.Tests
{
    [TestClass()]
    public class CountDistinctSlicesTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var M = 6;
            var A = new[] { 3, 4, 5, 5, 2 };
            var actual = CountDistinctSlices.Solution(M, A);
            var expected = 9;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_1()
        {
            var M = 6;
            var A = new[] { 3, 4, 5, 5, 5 };
            var actual = CountDistinctSlices.Solution(M, A);
            var expected = 8;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var M = 6;
            var A = new[] { 3, 3, 3, 4, 5, 5, 5 };
            var actual = CountDistinctSlices.Solution(M, A);
            var expected = 10;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var M = 6;
            var A = new[] { 3, 4, 5, 2, 2, 5, 2 };
            //(3, 4, 5, 2) + (2, 5) + (5, 2) - duplicate 5(index is A.Length - 2)
            var actual = CountDistinctSlices.Solution(M, A);
            var expected = 15;

            Assert.AreEqual(actual, expected);
        }
    }
}