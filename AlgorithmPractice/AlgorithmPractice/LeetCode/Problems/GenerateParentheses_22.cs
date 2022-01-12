using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems
{
    public class GenerateParentheses_22
    {
        #region topic
        /*
         give a number n, write a function to generate all combinations of well-formed parentheses.
         ex. n = 3, output = ["((()))","(()())","(())()","()(())","()()()"]
             n = 1, output = ["()"]

         copy@right:https://leetcode.com/problems/generate-parentheses/
         */
        #endregion

        public static IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            Recursive(n, n, "", list);
            return list;
        }

        private static void Recursive(int leftCount, int rightCount, string tempResult, List<string> list)
        {
            if (leftCount == 0 && rightCount == 0)
                list.Add(tempResult);
            if (leftCount > 0)
                Recursive(leftCount - 1, rightCount, tempResult + "(", list);
            if (rightCount > leftCount)
                Recursive(leftCount, rightCount - 1, tempResult + ")", list);
        }
    }
}
