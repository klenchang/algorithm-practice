using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.Tree.Tests
{
    [TestClass()]
    public class FindLowestCommonAncestorTests
    {
        [TestMethod()]
        public void LCATest_1()
        {
            var node1 = new FindLowestCommonAncestor.Node { Data = 1 };
            var node2 = new FindLowestCommonAncestor.Node { Data = 2, Left = node1 };
            var node3 = new FindLowestCommonAncestor.Node { Data = 3, Left = node2 };
            var node7 = new FindLowestCommonAncestor.Node { Data = 7 };
            var node6 = new FindLowestCommonAncestor.Node { Data = 6, Right = node7 };
            var node4 = new FindLowestCommonAncestor.Node { Data = 4, Left = node3, Right = node6 };
            var v1 = 1;
            var v2 = 7;
            var actual = FindLowestCommonAncestor.LCA(node4, v1, v2);
            var expected = node4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LCATest_2()
        {
            var node2 = new FindLowestCommonAncestor.Node { Data = 2 };
            var node1 = new FindLowestCommonAncestor.Node { Data = 1, Right = node2 };
            var v1 = 1;
            var v2 = 2;
            var actual = FindLowestCommonAncestor.LCA(node1, v1, v2);
            var expected = node1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LCATest_3()
        {
            var node2 = new FindLowestCommonAncestor.Node { Data = 2 };
            var node4 = new FindLowestCommonAncestor.Node { Data = 4 };
            var node3 = new FindLowestCommonAncestor.Node { Data = 3, Left = node2, Right = node4 };
            var node6 = new FindLowestCommonAncestor.Node { Data = 6 };
            var node7 = new FindLowestCommonAncestor.Node { Data = 7, Left = node6 };
            var node8 = new FindLowestCommonAncestor.Node { Data = 8, Left = node7 };
            var node5 = new FindLowestCommonAncestor.Node { Data = 5, Left = node3, Right = node8 };
            var v1 = 7;
            var v2 = 3;
            var actual = FindLowestCommonAncestor.LCA(node5, v1, v2);
            var expected = node5;
            Assert.AreEqual(expected, actual);
        }
    }
}