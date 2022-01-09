using System;

namespace AlgorithmPractice.Codility.Lessons.PrimeAndCompositeNumbers
{
    public class CountFactors
    {
        #region topic
        /*
        A positive integer D is a factor of a positive integer N if 
        there exists an integer M such that N = D * M.

        For example, 6 is a factor of 24, 
        because M = 4 satisfies the above condition (24 = 6 * 4).

        Write a function:

            class Solution { public int solution(int N); }

        that, given a positive integer N, returns the number of its factors.

        For example, given N = 24, the function should return 8, 
        because 24 has 8 factors, namely 1, 2, 3, 4, 6, 8, 12, 24. 
        There are no other factors of 24.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..2,147,483,647].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(sqrt(N))
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int Solution(int N)
        {
            var i = 1;
            var factorNum = 0;
            while ((long)i * (long)i < N)
            {
                if (N % i == 0)
                    factorNum += 2;
                i++;
            }

            if (i * i == N)
                factorNum++;

            return factorNum;
        }

        public static int SolutionWithSqrt(int N)
        {
            var sqrt = (int)Math.Sqrt(N);
            var res = 0;
            for (int i = 1; i <= sqrt; i++)
                if (N % i == 0)
                    res += (i * i == N ? 1 : 2);

            return res;
        }
    }
}
