﻿using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.CountingElements
{
    public class MaxCounters
    {
        #region topic
        /*
        You are given N counters, initially set to 0, and you have two possible operations on them:
        increase(X) − counter X is increased by 1,
        max counter − all counters are set to the maximum value of any counter.
        A non-empty array A of M integers is given. This array represents consecutive operations:

        if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
        if A[K] = N + 1 then operation K is max counter.
        For example, given integer N = 5 and array A such that:
            A[0] = 3
            A[1] = 4
            A[2] = 4
            A[3] = 6
            A[4] = 1
            A[5] = 4
            A[6] = 4
        the values of the counters after each consecutive operation will be:
            (0, 0, 1, 0, 0)
            (0, 0, 1, 1, 0)
            (0, 0, 1, 2, 0)
            (2, 2, 2, 2, 2)
            (3, 2, 2, 2, 2)
            (3, 2, 2, 3, 2)
            (3, 2, 2, 4, 2)
        The goal is to calculate the value of every counter after all operations.
        Write a function:

            class Solution { public int[] solution(int N, int[] A); }
        
        that, given an integer N and a non-empty array A consisting of M integers, 
        returns a sequence of integers representing the values of the counters.

        For example, given:
            A[0] = 3
            A[1] = 4
            A[2] = 4
            A[3] = 6
            A[4] = 1
            A[5] = 4
            A[6] = 4
        the function should return [3, 2, 2, 4, 2], as explained above.

        Write an efficient algorithm for the following assumptions:
            N and M are integers within the range [1..100,000];
            each element of array A is an integer within the range [1..N + 1].

        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * M), timeout when large data
        /// </summary>
        /// <param name="N"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] Solution1(int N, int[] A)
        {
            var result = new int[N];
            foreach (var n in A)
            {
                if (n == N + 1)
                    result = Enumerable.Repeat(result.Max(), N).ToArray();
                else
                    result[n - 1]++;
            }

            return result;
        }

        /// <summary>
        /// time complexity: O(N + M)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] Solution2(int N, int[] A)
        {
            var difference = new Dictionary<int, int>();
            var currentBase = 0;
            foreach (var n in A)
            {
                if (n == N + 1)
                {
                    currentBase += difference.Count == 0 ? 0 : difference.Max(kv => kv.Value);
                    difference = new Dictionary<int, int>();
                }
                else
                {
                    if (difference.ContainsKey(n - 1))
                        difference[n - 1]++;
                    else
                        difference.Add(n - 1, 1);
                }
            }
            var result = new int[N];
            for (int index = 0; index < result.Length; index++)
            {
                if (difference.ContainsKey(index))
                    result[index] = currentBase + difference[index];
                else
                    result[index] = currentBase;
            }

            return result;
        }
    }
}
