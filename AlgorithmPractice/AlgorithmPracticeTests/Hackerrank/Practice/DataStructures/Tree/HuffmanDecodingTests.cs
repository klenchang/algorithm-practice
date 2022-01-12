using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree.Tests
{
    [TestClass()]
    public class HuffmanDecodingTests
    {
        [TestMethod()]
        public void DecodeTest()
        {
            var nodeB = new HuffmanDecoding.DecodingNode("B");
            var nodeC = new HuffmanDecoding.DecodingNode("C");
            var nodeBC = new HuffmanDecoding.DecodingNode("") { left = nodeB, right = nodeC };
            var nodeA = new HuffmanDecoding.DecodingNode("A");
            var nodeABC = new HuffmanDecoding.DecodingNode("") { left = nodeBC, right = nodeA };
            var s = "1001011";
            var actual = HuffmanDecoding.Decode(s, nodeABC);
            var expected = "ABACA";

            Assert.AreEqual(expected, actual);
        }
    }
}