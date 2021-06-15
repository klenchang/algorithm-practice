using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm.Tests
{
    [TestClass()]
    public class CommonTests
    {
        [TestMethod()]
        public void GCDTest()
        {
            var N = 16;
            var M = 12;
            var actual = Common.GCD(N, M);
            var expected = 4;

            Assert.AreEqual(actual, expected);
        }
    }
}