using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrefixSums.Tests
{
    [TestClass()]
    public class MushroomPickerTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new int[] { 2, 3, 7, 5, 1, 3, 9 };
            var K = 4;
            var M = 6;
            var actual = MushroomPicker.Solution(A, K, M);
            var expected = 25;

            Assert.AreEqual(expected, actual);
        }
    }
}