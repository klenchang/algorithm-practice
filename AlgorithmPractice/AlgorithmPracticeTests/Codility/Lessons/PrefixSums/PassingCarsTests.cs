using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.PrefixSums.Tests
{
    [TestClass()]
    public class PassingCarsTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            var array = new[] { 0, 1, 0, 1, 1 };
            var actual = PassingCars.Solution1(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var array = new[] { 0, 1, 0, 1, 1 };
            var actual = PassingCars.Solution2(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution3Test()
        {
            var array = new[] { 0, 1, 0, 1, 1 };
            var actual = PassingCars.Solution3(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}