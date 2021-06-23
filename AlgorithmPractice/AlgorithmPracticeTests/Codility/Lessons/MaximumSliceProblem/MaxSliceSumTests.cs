using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.MaximumSliceProblem.Tests
{
    [TestClass()]
    public class MaxSliceSumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 3, 2, -6, 4, 0 };
            var actual = MaxSliceSum.Solution(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { -1000000, 0, 1000000, -1000000, 1000000, -1000000 };
            var actual = MaxSliceSum.Solution(array);
            var expected = 1000000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var array = new[] { -10 };
            var actual = MaxSliceSum.Solution(array);
            var expected = -10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_4()
        {
            var array = new[] { -10, -5 };
            var actual = MaxSliceSum.Solution(array);
            var expected = -5;

            Assert.AreEqual(expected, actual);
        }
    }
}