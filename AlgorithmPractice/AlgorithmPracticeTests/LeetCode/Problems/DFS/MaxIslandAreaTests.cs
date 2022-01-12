using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.DFS.Tests
{
    [TestClass()]
    public class MaxIslandAreaTests
    {
        [TestMethod()]
        public void MaxAreaOfIslandTest()
        {
            var grid = new int[][]
            {
                new [] { 0, 1, 0, 1, 1 },
                new [] { 1, 1, 1, 0, 0 },
                new [] { 1, 1, 0, 0, 1 },
                new [] { 0, 1, 0, 1, 1 },
            };
            var actual = MaxIslandArea_695.MaxAreaOfIsland(grid);
            var expected = 7;

            Assert.AreEqual(expected, actual);
        }
    }
}