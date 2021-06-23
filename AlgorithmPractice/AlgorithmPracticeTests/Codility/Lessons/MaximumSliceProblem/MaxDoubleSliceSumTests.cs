using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.MaximumSliceProblem.Tests
{
    [TestClass()]
    public class MaxDoubleSliceSumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 3, 2, 6, -1, 4, 5, -1, 2 };
            var actual = MaxDoubleSliceSum.Solution(array);
            var expected = 17;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_1()
        {
            var array = new[] { 1, 2, 3 };
            var actual = MaxDoubleSliceSum.Solution(array);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { 3, -10, 6, -4, 4, 5, -1, 2, 5 };
            var actual = MaxDoubleSliceSum.Solution(array);
            var expected = 16;

            Assert.AreEqual(expected, actual);
        }
    }
}