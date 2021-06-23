using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Sorting.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void SolutionTest_Sample1()
        {
            var array = new[] { 10, 2, 5, 1, 8, 20 };
            var actual = Triangle.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_Sample2()
        {
            var array = new[] { 10, 50, 5,1};
            var actual = Triangle.Solution(array);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_CriticalValue()
        {
            var array = new[] { 2147483647, 2147483646, 2147483647 };
            var actual = Triangle.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}