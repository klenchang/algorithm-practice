using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Arrays.Tests
{
    [TestClass()]
    public class OddOccurrencesInArrayTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 9, 3, 9, 3, 9, 7, 9 };
            var actual = OddOccurrencesInArray.Solution(A);
            var expected = 7;

            Assert.AreEqual(expected, actual);
        }
    }
}