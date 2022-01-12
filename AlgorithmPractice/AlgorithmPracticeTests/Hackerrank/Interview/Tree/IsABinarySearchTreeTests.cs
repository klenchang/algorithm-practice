using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Interview.Tree.Tests
{
    [TestClass()]
    public class IsABinarySearchTreeTests
    {
        [TestMethod()]
        public void BSTCheck()
        {
            var node = new IsABinarySearchTree.Node
            {
                Data = 4,
                Left = new IsABinarySearchTree.Node
                {
                    Data = 2,
                    Left = new IsABinarySearchTree.Node { Data = 1 },
                    Right = new IsABinarySearchTree.Node { Data = 3 }
                },
                Right = new IsABinarySearchTree.Node
                {
                    Data = 6,
                    Left = new IsABinarySearchTree.Node { Data = 5 },
                    Right = new IsABinarySearchTree.Node { Data = 7 }
                }
            };

            var actual = IsABinarySearchTree.CheckBST(node);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NotBSTCheck()
        {
            var node = new IsABinarySearchTree.Node
            {
                Data = 3,
                Left = new IsABinarySearchTree.Node
                {
                    Data = 2,
                    Left = new IsABinarySearchTree.Node { Data = 1 }
                },
                Right = new IsABinarySearchTree.Node
                {
                    Data = 5,
                    Left = new IsABinarySearchTree.Node { Data = 6 },
                    Right = new IsABinarySearchTree.Node { Data = 1 }
                }
            };

            var actual = IsABinarySearchTree.CheckBST(node);
            Assert.IsFalse(actual);
        }
    }
}