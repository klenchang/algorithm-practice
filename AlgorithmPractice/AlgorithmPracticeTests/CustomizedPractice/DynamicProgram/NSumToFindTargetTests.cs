using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.CustomizedPractice.DynamicProgram.Tests
{
    [TestClass()]
    public class NSumToFindTargetTests
    {
        [TestMethod()]
        public void CountTestWithRecursive()
        {
            var array = new[] { 2, 4, 6, 10 };
            var target = 16;
            var actual = NSumToFindTarget.SolutionWithRecursive.Count(array, target);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountTestWithRecursiveAndMemoized()
        {
            var array = new[] { 2, 4, 6, 10 };
            var target = 16;
            var actual = NSumToFindTarget.SolutionWithRecursiveAndMemoized.CountWithDP(array, target);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}