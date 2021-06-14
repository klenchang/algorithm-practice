using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues.Tests
{
    [TestClass()]
    public class StoneWallTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            var actual = StoneWall.Solution(array);
            var expected = 7;

            Assert.AreEqual(actual, expected);
        }
    }
}