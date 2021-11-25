using System;

namespace AlgorithmPractice.Codility.Lessons.MaximumSliceProblem
{
    public class MaxProfit
    {
        #region topic
        /*
        An array A consisting of N integers is given. 
        It contains daily prices of a stock share for a period of N consecutive days.
        If a single share was bought on day P and sold on day Q, where 0 ≤ P ≤ Q < N,
        then the profit of such transaction is equal to A[Q] − A[P], 
        provided that A[Q] ≥ A[P]. Otherwise, the transaction brings loss of A[P] − A[Q].

        For example, consider the following array A consisting of six elements such that:
            A[0] = 23171
            A[1] = 21011
            A[2] = 21123
            A[3] = 21366
            A[4] = 21013
            A[5] = 21367
        If a share was bought on day 0 and sold on day 2, a loss of 2048 would 
        occur because A[2] − A[0] = 21123 − 23171 = −2048.
        If a share was bought on day 4 and sold on day 5,
        a profit of 354 would occur because A[5] − A[4] = 21367 − 21013 = 354. 
        Maximum possible profit was 356. 
        It would occur if a share was bought on day 1 and sold on day 5.
        
        Write a function,

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers containing 
        daily prices of a stock share for a period of N consecutive days, 
        returns the maximum possible profit from one transaction during this period. 
        The function should return 0 if it was impossible to gain any profit.

        For example, given array A consisting of six elements such that:
            A[0] = 23171
            A[1] = 21011
            A[2] = 21123
            A[3] = 21366
            A[4] = 21013
            A[5] = 21367
        the function should return 356, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..400,000];
            each element of array A is an integer within the range [0..200,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            // caculate min cost for everyday.
            var minCost = new int[A.Length];
            for (int i = 0; i < minCost.Length; i++)
                minCost[i] = (i == 0) ? A[i] : Math.Min(minCost[i - 1], A[i]);

            // caculate profit for everyday, need to notice to minus cost of yesterday,
            // because you cannot buy and sell at the same day.
            var maxProfit = 0;
            for (int i = 1; i < A.Length; i++)
            {
                var currentProfit = A[i] - minCost[i - 1];
                if (currentProfit > maxProfit)
                    maxProfit = currentProfit;
            }

            return maxProfit;
        }

        public int Solution2(int[] A)
        {
            if (A.Length < 2) return 0;
            var min = A[0];
            var maxProfit = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] - min < 0)
                    min = A[i];
                else if (A[i] - min > maxProfit)
                    maxProfit = A[i] - min;
            }
            return maxProfit;
        }
    }
}
