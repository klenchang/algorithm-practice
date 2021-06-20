using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.FutureTraining.Tests
{
    [TestClass()]
    public class StrSymmetryPointTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var S = "racecar";
            var actual = StrSymmetryPoint.Solution(S);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var S = "x";
            var actual = StrSymmetryPoint.Solution(S);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}