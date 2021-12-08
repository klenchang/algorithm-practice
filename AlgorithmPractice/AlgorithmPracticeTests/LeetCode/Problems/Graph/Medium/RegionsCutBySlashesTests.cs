using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium.Tests
{
    [TestClass()]
    public class RegionsCutBySlashesTests
    {
        [TestMethod()]
        public void RegionsBySlashesTest()
        {
            var grid = new[] { "/\\", "\\/" };
            var actual = RegionsCutBySlashes.RegionsBySlashes(grid);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}