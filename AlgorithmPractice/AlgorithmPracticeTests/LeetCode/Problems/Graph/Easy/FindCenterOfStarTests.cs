using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Easy.Tests
{
    [TestClass()]
    public class FindCenterOfStarTests
    {
        [TestMethod()]
        public void Find_Center_Of_Three_Edges()
        {
            var edges = new int[][] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 4, 2 } };
            var actual = FindCenterOfStar_1791.FindCenter(edges);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}