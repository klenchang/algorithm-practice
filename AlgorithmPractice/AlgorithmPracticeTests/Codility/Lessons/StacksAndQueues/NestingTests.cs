using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues.Tests
{
    [TestClass()]
    public class NestingTests
    {
        [TestMethod()]
        public void SolutionTest_Nested()
        {
            var s = "WD(()(W(W)W)W())WD";
            var actual = Nesting.Solution(s);
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_NotNested()
        {
            var s = "())";
            var actual = Nesting.Solution(s);
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }
    }
}