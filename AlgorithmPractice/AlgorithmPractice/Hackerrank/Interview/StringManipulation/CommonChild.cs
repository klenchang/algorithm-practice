using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation
{
    public class CommonChild
    {
        #region topic
        /*
        A string is said to be a child of a another string if it can be formed by deleting 0 
        or more characters from the other string. 
        Letters cannot be rearranged. Given two strings of equal length, 
        what's the longest string that can be constructed such that it is a child of both? 

        Example.
        s1 = "ABCD", s2 = "ABDC" => return 3. because longest is ABC.
        s1 = "HARRY", s2 = "SALLY" => return 2. "AY"
        s1 = "AA", s2 = "BB" => return 0.
        s1 = "SHINCHAN", s2 = "NOHARAAA" => return 3. NHA
        s1 = "ABCDEF", s2 = "FBDAMN" => return 2. BD

        Constraints
        1 <= s1,s2 <= 5000
        All characters are upper case in the range ascii[A-Z].
         */
        #endregion

        //refer to https://dev.to/nrymarz/hackerrank-s-common-child-problem-solution-and-dynamic-programming-3nb7
        public static int Solution(string s1, string s2)
        {
            var dp = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 1; i < s1.Length + 1; i++)
            {
                for (int j = 1; j < s2.Length + 1; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                }
            }

            return dp[s1.Length, s2.Length];
        }
    }
}
