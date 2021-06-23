using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues.Tests
{
    [TestClass()]
    public class BracketsTests
    {
        [TestMethod()]
        public void SolutionTest_Nested()
        {
            var s = "{[()()]}";
            var actual = Brackets.Solution1(s);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_NotNested()
        {
            var s = "([)()]";
            var actual = Brackets.Solution1(s);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_NotNestedTwo()
        {
            var s = "]([)()]";
            var actual = Brackets.Solution1(s);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_Nested()
        {
            var s = "{[()()]}";
            var actual = Brackets.Solution2(s);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_NotNested()
        {
            var s = "([)()]";
            var actual = Brackets.Solution2(s);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_NotNestedTwo()
        {
            var s = "]([)()]";
            var actual = Brackets.Solution2(s);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}