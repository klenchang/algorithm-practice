using AlgorithmPractice.Codility.Lessons.Leader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Leader.Tests
{
    [TestClass()]
    public class EquiLeaderTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { 0, 0 };
            var actual = EquiLeader.Solution(array);
            var expected = 1;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { 4, 3, 4, 4, 4, 2 };
            var actual = EquiLeader.Solution(array);
            var expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var array = new[] { 0 };
            var actual = EquiLeader.Solution(array);
            var expected = 0;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FindLeaderAndCountTest()
        {
            var array = new[] { 0, 0 };
            var actual = EquiLeader.FindLeaderAndCount(array);
            var expected = "0,2";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FindLeaderAndCountTest_2()
        {
            var array = new[] { 0, 0, 3, 4 };
            var actual = EquiLeader.FindLeaderAndCount(array);
            var expected = "-1";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FindLeaderAndCountTest_3()
        {
            var array = new[] { 0 };
            var actual = EquiLeader.FindLeaderAndCount(array);
            var expected = "0,1";

            Assert.AreEqual(actual, expected);
        }
    }
}