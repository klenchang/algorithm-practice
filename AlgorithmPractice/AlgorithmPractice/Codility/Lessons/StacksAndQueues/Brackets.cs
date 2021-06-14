using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.StacksAndQueues
{
    public class Brackets
    {
        #region topic
        /*
        A string S consisting of N characters is considered to be properly nested 
        if any of the following conditions is true:

        S is empty;
        S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
        S has the form "VW" where V and W are properly nested strings.
        
        For example, the string "{[()()]}" is properly nested but "([)()]" is not.
        Write a function:

            class Solution { public int solution(String S); }

        that, given a string S consisting of N characters, returns 1 if S is properly nested 
        and 0 otherwise.

        For example, 
        given S = "{[()()]}", the function should return 1 and 
        given S = "([)()]", the function should return 0, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..200,000];
            string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Solution1(string S)
        {
            var mapping = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };
            // if use List, it will cause time out issue when remove last element.
            StringBuilder sb = new StringBuilder();
            foreach (var c in S)
            {
                if (mapping.ContainsKey(c))
                    sb.Append(c);
                else
                {
                    if (sb.Length == 0) return 0;
                    var last = sb[sb.Length - 1];
                    if (mapping[last] == c)
                        sb.Remove(sb.Length - 1, 1);
                    else return 0;
                }
            }
            return sb.Length == 0 ? 1 : 0;
        }

        /// <summary>
        /// time complexity: O(N), use Stack
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Solution2(string S)
        {
            var mapping = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };
            Stack<char> stack = new Stack<char>();
            foreach (var c in S)
            {
                if (mapping.ContainsKey(c))
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0) return 0;
                    if (mapping[stack.Peek()] == c)
                        stack.Pop();
                    else
                        return 0;
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
    }
}
