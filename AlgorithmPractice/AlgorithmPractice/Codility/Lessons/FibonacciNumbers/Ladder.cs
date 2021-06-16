using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers
{
    public class Ladder
    {
        #region topic
        /*
        You have to climb up a ladder. 
        The ladder has exactly N rungs, numbered from 1 to N. With each step, 
        you can ascend by one or two rungs. 
        
        More precisely:
        with your first step you can stand on rung 1 or 2,
        if you are on rung K, you can move to rungs K + 1 or K + 2,
        finally you have to stand on rung N.
        Your task is to count the number of different ways of 
        climbing to the top of the ladder.

        For example, given N = 4, you have five different ways of climbing, ascending by:
            1, 1, 1 and 1 rung,
            1, 1 and 2 rungs,
            1, 2 and 1 rung,
            2, 1 and 1 rungs, and 
            2 and 2 rungs.
        Given N = 5, you have eight different ways of climbing, ascending by:
            1, 1, 1, 1 and 1 rung,
            1, 1, 1 and 2 rungs,
            1, 1, 2 and 1 rung,
            1, 2, 1 and 1 rung,
            1, 2 and 2 rungs,
            2, 1, 1 and 1 rungs,
            2, 1 and 2 rungs, and
            2, 2 and 1 rung.
        The number of different ways can be very large, 
        so it is sufficient to return the result modulo 2^P, for a given integer P.
        Write a function:

            class Solution { public int[] solution(int[] A, int[] B); }

        that, given two non-empty arrays A and B of L integers, 
        returns an array consisting of L integers specifying the consecutive answers; 
        position I should contain the number of different ways of climbing the ladder 
        with A[I] rungs modulo 2^B[I].

        For example, given L = 5 and:
            A[0] = 4   B[0] = 3
            A[1] = 4   B[1] = 2
            A[2] = 5   B[2] = 4
            A[3] = 5   B[3] = 3
            A[4] = 1   B[4] = 1
        the function should return the sequence [5, 1, 8, 0, 1], as explained above.

        Write an efficient algorithm for the following assumptions:
            L is an integer within the range [1..50,000];
            each element of array A is an integer within the range [1..L];
            each element of array B is an integer within the range [1..30].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(L)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] Solution(int[] A, int[] B)
        {
            var maxN = A.Max();
            var fx = new int[maxN + 2];
            fx[0] = 0;
            fx[1] = 1;
            var maxP = (1 << 30) - 1;
            // x % 2^y = x & ((2<<y) - 1)
            // because 1<=B[I]<=30, x & ((1<<30)-1) & ((1<<B[I])-1) = x & ((1<<B)-1)
            for (int i = 2; i < fx.Length; i++)
                fx[i] = (fx[i - 1] + fx[i - 2]) & maxP;

            var result = new int[A.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = fx[A[i] + 1] & ((1 << B[i]) - 1);

            return result;
        }
    }
}
