﻿using System;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.MaximumSliceProblem
{
    public class MaxSliceSum
    {
        #region topic
        /*
        A non-empty array A consisting of N integers is given. 
        A pair of integers (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A. 
        The sum of a slice (P, Q) is the total of A[P] + A[P+1] + ... + A[Q].
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns the maximum sum of any slice of A.

        For example, given array A such that:
            A[0] = 3  A[1] = 2  A[2] = -6
            A[3] = 4  A[4] = 0
        the function should return 5 because:
            (3, 4) is a slice of A that has sum 4,
            (2, 2) is a slice of A that has sum −6,
            (0, 1) is a slice of A that has sum 5,
        no other slice of A has sum greater than (0, 1).

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..1,000,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000];
            the result will be an integer within the range [−2,147,483,648..2,147,483,647].
        
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
            var max = new long[A.Length];
            max[0] = A[0];
            for (int i = 1; i < max.Length; i++)
                max[i] = Math.Max(A[i], (long)max[i - 1] + (long)A[i]);

            return (int)max.Max();
        }

        public static int SolutionWithLessSpace(int[] A)
        {
            var max = A[0];
            var temp = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                temp += A[i];
                if (temp < A[i])
                    temp = A[i];

                if (max < temp)
                    max = temp;
            }
            return max;
        }
    }
}
