using System;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.DynamicProgramming
{
    public class MinAbsSum
    {
        #region topic
        /*
        For a given array A of N integers and a sequence S of N integers 
        from the set {−1, 1}, we define val(A, S) as follows:

            val(A, S) = |sum{ A[i]*S[i] for i = 0..N−1 }|

        (Assume that the sum of zero elements equals zero.)

        For a given array A, we are looking for such a sequence S that minimizes val(A,S).

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A of N integers, computes the minimum value of val(A,S) 
        from all possible values of val(A,S) for all possible sequences S of N integers 
        from the set {−1, 1}.

        For example, given array:
          A[0] =  1
          A[1] =  5
          A[2] =  2
          A[3] = -2
        your function should return 0, since for S = [−1, 1, −1, 1], val(A, S) = 0,
        which is the minimum possible value.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..20,000];
            each element of array A is an integer within the range [−100..100].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * max(abs(A)) ** 2)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            if (A.Length == 0) return 0;
            var sum = 0;
            var max = 0;
            // let all elements to be positive
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Math.Abs(A[i]);
                if (A[i] > max)
                    max = A[i];
                sum += A[i];
            }
            // count times for each elements 
            var counts = new int[max + 1];
            foreach (var a in A)
                counts[a]++;
            // caculate dp
            // if dp[y] > 0 means we can make some elements sum is y
            var dp = Enumerable.Repeat(-1, sum + 1).ToArray();
            dp[0] = 0;
            for (int i = 1; i < counts.Length; i++)
            {
                // there exists number abs(i) in A
                if (counts[i] > 0)
                {
                    for (int y = 0; y < dp.Length; y++)
                    {
                        // if dp[y] >= 0, means previous sum value already can get y
                        // then we update dp[y] = count[i] and use them in else if condition
                        // if dp[y] < 0, then check dp[y-i] whether > 0
                        // if dp[y-1] > 0, means we can get sum by dp[y-i] - 1
                        // minus 1 means to cost one element that value is i
                        if (dp[y] >= 0)
                            dp[y] = counts[i];
                        else if (y - i >= 0 && dp[y - i] > 0)
                            dp[y] = dp[y - i] - 1;
                    }
                }
            }
            var result = sum;
            // The closest middle value may get the smallest gap
            // We want to find a P to let |Q - P| is smallest
            // Q = Sum - P, |Q - P| = |Sum - P - P| = |Sum - 2P|
            for (int i = 0; i < (sum / 2) + 1; i++)
            {
                if (dp[i] >= 0)
                {
                    var gap = sum - 2 * i;
                    if (gap < result)
                        result = gap;
                }
            }

            return result;
        }
    }
}
