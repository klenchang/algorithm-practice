using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Sorting.Tests
{
    [TestClass()]
    public class DistinctTests
    {
        [TestMethod()]
        public void SolutionTest_NormalCase()
        {
            var array = new[] { 2, 1, 1, 2, 3, 1 };
            var actual = Distinct.Solution(array);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_EmptyArray()
        {
            var array = new int[] { };
            var actual = Distinct.Solution(array);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_OneElementArray()
        {
            var array = new int[] { -1000 };
            var actual = Distinct.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var array = new[] { 2, 1, 1, 2, 3, 1 };
            var actual = Distinct.Solution2(array);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}