using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.LeetCode.Problems.Tests
{
    [TestClass()]
    public class GenerateParenthesesTests
    {
        [TestMethod()]
        public void GenerateParenthesisWithNEqualOne()
        {
            var n = 1;
            var actual = GenerateParentheses.GenerateParenthesis(n).ToList();
            var expected = new List<string> { "()" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GenerateParenthesisWithNEqualThree()
        {
            var n = 3;
            var actual = GenerateParentheses.GenerateParenthesis(n).ToList();
            var expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}