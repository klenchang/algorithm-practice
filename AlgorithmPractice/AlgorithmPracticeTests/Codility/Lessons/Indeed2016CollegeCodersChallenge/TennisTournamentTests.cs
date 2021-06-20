using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2016CollegeCodersChallenge.Tests
{
    [TestClass()]
    public class TennisTournamentTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var P = 10;
            var C = 3;
            var actual = TennisTournament.Solution(P, C);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var P = 5;
            var C = 3;
            var actual = TennisTournament.Solution(P, C);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}