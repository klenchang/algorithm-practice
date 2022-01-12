using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.DFS.Tests
{
    [TestClass()]
    public class CalculateIslandPerimeterTests
    {
        [TestMethod()]
        public void IslandPerimeterTest()
        {
            var grid = new int[][]
            {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 },
            };
            var actual = CalculateIslandPerimeter_463.IslandPerimeter(grid);
            var expected = 16;

            Assert.AreEqual(expected, actual);
        }
    }
}