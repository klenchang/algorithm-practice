using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Sorting.Tests
{
    [TestClass()]
    public class MaxProductOfThreeTests
    {
        [TestMethod()]
        public void SolutionTest_NormalCase()
        {
            var array = new[] { -3, 1, 2, -2, 5, 6 };
            var actual = MaxProductOfThree.Solution(array);
            var expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_ThreeElement()
        {
            var array = new[] { 100, 1, -100 };
            var actual = MaxProductOfThree.Solution(array);
            var expected = -10000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_Zero()
        {
            var array = new[] { 100, 0, -100, 20, -50 };
            var actual = MaxProductOfThree.Solution(array);
            var expected = 500000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionTest_TwoNThreeP()
        {
            var array = new[] { -4, -6, 3, 4, 5 };
            var actual = MaxProductOfThree.Solution(array);
            var expected = 120;

            Assert.AreEqual(expected, actual);
        }
    }
}