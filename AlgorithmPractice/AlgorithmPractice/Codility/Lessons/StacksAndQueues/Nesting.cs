using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues
{
    public class Nesting
    {
        #region topic
        /*
        A string S consisting of N characters is called properly nested if:
        S is empty;
        S has the form "(U)" where U is a properly nested string;
        S has the form "VW" where V and W are properly nested strings.
        For example, string "(()(())())" is properly nested but string "())" isn't.

        Write a function:

            class Solution { public int solution(String S); }

        that, given a string S consisting of N characters, 
        returns 1 if string S is properly nested and 0 otherwise.

        For example, given S = "(()(())())", the function should return 1 and given S = "())", 
        the function should return 0, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..1,000,000];
            string S consists only of the characters "(" and/or ")".
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Solution(string S)
        {
            if (string.IsNullOrEmpty(S)) return 1;
            var stack = new Stack<char>();
            foreach (var c in S)
            {
                if (c == '(') stack.Push('(');
                else if(c == ')')
                {
                    if (stack.Count == 0) return 0;
                    else stack.Pop();
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
    }
}
