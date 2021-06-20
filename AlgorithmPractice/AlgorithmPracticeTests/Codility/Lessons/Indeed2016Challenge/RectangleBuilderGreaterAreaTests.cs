using AlgorithmPractice.Codility.Lessons.Indeed2016Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2016Challenge.Tests
{
    [TestClass()]
    public class RectangleBuilderGreaterAreaTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var A = new[] { 1, 2, 5, 1, 1, 2, 3, 5, 1 };
            var X = 5;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var A = new[] { 6, 6, 6, 6, 6, 6 };
            var X = 10;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var A = new[] { 2, 2, 2 };
            var X = 4;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var A = new[] { 3, 8, 9, 5, 8, 8, 9, 3, 8, 5, 10 };
            var X = 20;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest4()
        {
            var A = new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var X = 103;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest5()
        {
            var A = new[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912 };
            var X = 536870912;
            var actual = RectangleBuilderGreaterArea.Solution(A, X);
            var expected = 225;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test()
        {
            var A = new[] { 1, 2, 5, 1, 1, 2, 3, 5, 1 };
            var X = 5;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test1()
        {
            var A = new[] { 6, 6, 6, 6, 6, 6 };
            var X = 10;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test2()
        {
            var A = new[] { 2, 2, 2 };
            var X = 4;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test3()
        {
            var A = new[] { 3, 8, 9, 5, 8, 8, 9, 3, 8, 5, 10 };
            var X = 20;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test4()
        {
            var A = new[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var X = 103;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution2Test5()
        {
            var A = new[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912 };
            var X = 536870912;
            var actual = RectangleBuilderGreaterArea.Solution2(A, X);
            var expected = 225;

            Assert.AreEqual(expected, actual);
        }
    }
}