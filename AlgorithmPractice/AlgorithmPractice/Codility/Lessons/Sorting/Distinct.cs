using System;

namespace AlgorithmPractice.Codility.Lessons.Sorting
{
    public class Distinct
    {
        #region topic
        /*
        Write a function

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns the number of distinct values in array A.

        For example, given array A consisting of six elements such that:
         A[0] = 2    A[1] = 1    A[2] = 1
         A[3] = 2    A[4] = 3    A[5] = 1
        the function should return 3, 
        because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        ///  time complexity: O(N * log(N)) or O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return 1;

            Array.Sort(A);
            // default is 1, because first element
            var distinctCount = 1;
            // check others elements that not first and last element
            for (int index = 1; index < A.Length; index++)
                if (A[index] != A[index - 1])
                    distinctCount++;

            return distinctCount;
        }
    }
}
