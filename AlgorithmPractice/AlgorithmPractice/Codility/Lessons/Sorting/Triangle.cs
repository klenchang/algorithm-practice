using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Codility.Lessons.Sorting
{
    public class Triangle
    {
        #region topic
        /*
        An array A consisting of N integers is given. 
        A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:
            A[P] + A[Q] > A[R],
            A[Q] + A[R] > A[P],
            A[R] + A[P] > A[Q].
        For example, consider array A such that:
            A[0] = 10    A[1] = 2    A[2] = 5
            A[3] = 1     A[4] = 8    A[5] = 20
        Triplet (0, 2, 4) is triangular.

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.

        For example, given array A such that:
          A[0] = 10    A[1] = 2    A[2] = 5
          A[3] = 1     A[4] = 8    A[5] = 20
        the function should return 1, as explained above. Given array A such that:
          A[0] = 10    A[1] = 50    A[2] = 5
          A[3] = 1
        the function should return 0.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * log(N))
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            Array.Sort(A);
            for (int index = A.Length - 1; index >= 2; index--)
                if ((long)A[index - 2] + (long)A[index - 1] > (long)A[index])
                    return 1;

            return 0;
        }
    }
}
