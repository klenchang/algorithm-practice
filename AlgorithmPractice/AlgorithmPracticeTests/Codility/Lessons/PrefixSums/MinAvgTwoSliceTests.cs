using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrefixSums.Tests
{
    [TestClass()]
    public class MinAvgTwoSliceTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { -3, -5, -8, -4, -10 };
            var actual = MinAvgTwoSlice.Solution(array);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }
    }
}