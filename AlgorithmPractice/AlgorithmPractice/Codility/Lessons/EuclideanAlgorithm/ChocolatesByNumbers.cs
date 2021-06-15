using System;

namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm
{
    public class ChocolatesByNumbers
    {
        #region topic
        /*
        Two positive integers N and M are given. 
        Integer N represents the number of chocolates arranged in a circle, numbered from 0 to N − 1.

        You start to eat the chocolates. 
        After eating a chocolate you leave only a wrapper.

        You begin with eating chocolate number 0. 
        Then you omit the next M − 1 chocolates or wrappers on the circle, and eat the following one.

        More precisely, if you ate chocolate number X, 
        then you will next eat the chocolate with number (X + M) modulo N (remainder of division).

        You stop eating when you encounter an empty wrapper.

        For example, given integers N = 10 and M = 4. 
        You will eat the following chocolates: 0, 4, 8, 2, 6.

        The goal is to count the number of chocolates that you will eat, following the above rules.

        Write a function:

            class Solution { public int solution(int N, int M); }

        that, given two positive integers N and M, returns the number of chocolates that you will eat.

        For example, given integers N = 10 and M = 4. the function should return 5, as explained above.

        Write an efficient algorithm for the following assumptions:
            N and M are integers within the range [1..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(log(N + M))
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int Solution(int N, int M)
        {
            var gcd = GCD(Math.Max(N, M), Math.Min(N, M));
            var lcm = (long)N * (long)M / gcd;
            return (int)(lcm / M);
        }

        /// <summary>
        /// get gcd(N, M)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int GCD(int N, int M)
        {
            if (N % M == 0)
                return M;
            else
                return GCD(M, N % M);
        }
    }
}
