using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Easy.Tests
{
    [TestClass()]
    public class FindIfPathExistsinGraphTests
    {
        [TestMethod()]
        public void ValidPathWithDFS_Test1()
        {
            var edges = new int[][] 
            { 
                new[] { 0, 1 }, 
                new[] { 1, 2 },
                new[] { 2, 0 }  
            };
            var n = 3;
            var start = 0;
            var end = 2;
            var actual = FindIfPathExistsinGraph_1971.SolutionWithDFSRecursive.ValidPath(n, edges, start, end);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ValidPathWithDFS_Test2()
        {
            var edges = new int[][]
            {
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 3, 5 },
                new[] { 5, 4 },
                new[] { 4, 3 }
            };
            var n = 6;
            var start = 0;
            var end = 5;
            var actual = FindIfPathExistsinGraph_1971.SolutionWithDFSRecursive.ValidPath(n, edges, start, end);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void ValidPathWithHashMap_Test1()
        {
            var edges = new int[][]
            {
                new[] { 0, 1 },
                new[] { 1, 2 },
                new[] { 2, 0 }
            };
            var n = 3;
            var start = 0;
            var end = 2;
            var actual = FindIfPathExistsinGraph_1971.SolutionWithHashMap.ValidPath(n, edges, start, end);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ValidPathWithHashMap_Test2()
        {
            var edges = new int[][]
            {
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 3, 5 },
                new[] { 5, 4 },
                new[] { 4, 3 }
            };
            var n = 6;
            var start = 0;
            var end = 5;
            var actual = FindIfPathExistsinGraph_1971.SolutionWithHashMap.ValidPath(n, edges, start, end);

            Assert.IsFalse(actual);
        }
    }
}