using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod.Tests
{
    [TestClass()]
    public class AbsDistinctTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var array = new[] { -5, -3, -1, 0, 3, 6 };
            var actual = AbsDistinct.Solution(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_2()
        {
            var array = new[] { -1, -1, 0, 1, 1 };
            var actual = AbsDistinct.Solution(array);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_3()
        {
            var array = new[] { 0 };
            var actual = AbsDistinct.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest_4()
        {
            var array = new[] { 1, 1 };
            var actual = AbsDistinct.Solution(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var array = new[] { -5, -3, -1, 0, 3, 6 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_2()
        {
            var array = new[] { -1, -1, 0, 1, 1 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_3()
        {
            var array = new[] { 0 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_4()
        {
            var array = new[] { 1, 1 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_5()
        {
            var array = new[] { -2147483648, 0 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_6()
        {
            var array = new[] { -2147483648, -2147483648 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test_7()
        {
            var array = new[] { -2147483648, -2147483648, -10000, 10000, 10001 };
            var actual = AbsDistinct.Solution2(array);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}