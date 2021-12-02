using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.LeetCode.Problems.Tests
{
    [TestClass()]
    public class FindJudgeTests
    {
        [TestMethod()]
        public void FindJudgeInTwoPeople()
        {
            var n = 2;
            var trust = new int[][] { new[] { 1, 2 } };
            var actual = FindJudge.Find(n, trust);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeInThreePeople()
        {
            var n = 3;
            var trust = new int[][] { new[] { 1, 3 }, new[] { 2, 3 } };
            var actual = FindJudge.Find(n, trust);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CannotFindJudge_EveryoneTrustOthers()
        {
            var n = 3;
            var trust = new int[][] { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 1 } };
            var actual = FindJudge.Find(n, trust);
            var expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CannotFindJudge_NoOneGetAllTrust()
        {
            var n = 3;
            var trust = new int[][] { new[] { 1, 2 }, new[] { 2, 3 } };
            var actual = FindJudge.Find(n, trust);
            var expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindJudgeInFourPeople()
        {
            var n = 4;
            var trust = new int[][] { new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 3 } };
            var actual = FindJudge.Find(n, trust);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}