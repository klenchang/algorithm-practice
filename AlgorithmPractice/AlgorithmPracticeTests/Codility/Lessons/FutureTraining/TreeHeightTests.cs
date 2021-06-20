using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FutureTraining.Tests
{
    [TestClass()]
    public class TreeHeightTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            TreeHeight.Tree tree = new TreeHeight.Tree()
            {
                x = 5,
                l = new TreeHeight.Tree
                {
                    x = 3,
                    l = new TreeHeight.Tree { x = 20 },
                    r = new TreeHeight.Tree { x = 21 }
                },
                r = new TreeHeight.Tree
                {
                    x = 10,
                    l = new TreeHeight.Tree { x = 1 }
                }
            };
            var actual = TreeHeight.Solution(tree);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}