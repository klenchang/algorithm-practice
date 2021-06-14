﻿namespace AlgorithmPractice.Codility.Lessons.PrefixSums
{
    public class MinAvgTwoSlice
    {
        #region topic
        /*
        A non-empty array A consisting of N integers is given. A pair of integers (P, Q), 
        such that 0 ≤ P < Q < N, is called a slice of array A 
        (notice that the slice contains at least two elements). 
        
        The average of a slice (P, Q) is the sum of A[P] + A[P + 1] + ... + A[Q] 
        divided by the length of the slice. To be precise, 
        the average equals (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).
        
        For example, array A such that:
            A[0] = 4
            A[1] = 2
            A[2] = 2
            A[3] = 5
            A[4] = 1
            A[5] = 5
            A[6] = 8
        contains the following example slices:

        slice (1, 2), whose average is (2 + 2) / 2 = 2;
        slice (3, 4), whose average is (5 + 1) / 2 = 3;
        slice (1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.
        The goal is to find the starting position of a slice whose average is minimal.
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N integers, 
        returns the starting position of the slice with the minimal average. 
        
        If there is more than one slice with a minimal average, 
        you should return the smallest starting position of such a slice.

        For example, given array A such that:
            A[0] = 4
            A[1] = 2
            A[2] = 2
            A[3] = 5
            A[4] = 1
            A[5] = 5
            A[6] = 8
        the function should return 1, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [2..100,000];
            each element of array A is an integer within the range [−10,000..10,000].
        
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
            // notice need to use 2f, otherwise, the avg will miss decimal point
            var minAvg = (A[0] + A[1]) / 2f;
            var minPosition = 0;
            // run for each two elements
            for (int index = 0; index < A.Length - 1; index++)
            { 
                var avg = (A[index] + A[index + 1]) / 2f;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    minPosition = index;
                }
            }
            // run for each three elements
            for (int index = 0; index < A.Length - 2; index++)
            {
                var avg = (A[index] + A[index + 1] + A[index + 2]) / 3f;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    minPosition = index;
                }
            }
            return minPosition;
        }
    }
}
