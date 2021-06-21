using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FutureTraining.Tests
{
    [TestClass()]
    public class ArrayInversionCountTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { -1, 6, 3, 4, 7, 4 };
            var actual = ArrayInversionCount.Solution(A);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }

}