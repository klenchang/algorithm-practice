using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Easy.Tests
{
    [TestClass()]
    public class MinDepthOfBinaryTree_111Tests
    {
        [TestMethod()]
        public void MinDepthTest_1()
        {
            var node9 = new MinDepthOfBinaryTree_111.TreeNode { val = 9 };
            var node15 = new MinDepthOfBinaryTree_111.TreeNode { val = 15 };
            var node7 = new MinDepthOfBinaryTree_111.TreeNode { val = 7 };
            var node20 = new MinDepthOfBinaryTree_111.TreeNode { val = 20, left = node15, right = node7 };
            var node3 = new MinDepthOfBinaryTree_111.TreeNode { val = 3, left = node9, right = node20 };

            var actual = MinDepthOfBinaryTree_111.MinDepth(node3);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinDepthTest_2()
        {
            var node6 = new MinDepthOfBinaryTree_111.TreeNode { val = 6 };
            var node5 = new MinDepthOfBinaryTree_111.TreeNode { val = 5, right = node6 };
            var node4 = new MinDepthOfBinaryTree_111.TreeNode { val = 4, right = node5 };
            var node3 = new MinDepthOfBinaryTree_111.TreeNode { val = 3, right = node4 };
            var node2 = new MinDepthOfBinaryTree_111.TreeNode { val = 2, right = node3 };

            var actual = MinDepthOfBinaryTree_111.MinDepth(node2);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}