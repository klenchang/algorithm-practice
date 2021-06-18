using System;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod
{
    public class CountTriangles
    {
        #region topic
        /*
        An array A consisting of N integers is given. 
        A triplet (P, Q, R) is triangular if it is possible to build a triangle 
        with sides of lengths A[P], A[Q] and A[R]. 
        In other words, triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:
            A[P] + A[Q] > A[R],
            A[Q] + A[R] > A[P],
            A[R] + A[P] > A[Q].
        For example, consider array A such that:
            A[0] = 10    A[1] = 2    A[2] = 5
            A[3] = 1     A[4] = 8    A[5] = 12
        There are four triangular triplets that can be constructed from elements of 
        this array, namely (0, 2, 4), (0, 2, 5), (0, 4, 5), and (2, 4, 5).
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns the number of triangular triplets in this array.
        
        For example, given array A such that:
            A[0] = 10    A[1] = 2    A[2] = 5
            A[3] = 1     A[4] = 8    A[5] = 12
        the function should return 4, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..1,000];
            each element of array A is an integer within the range [1..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N ** 3), task score: 72%, correctness: 100, performance: 25 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            if (A.Length < 3) return 0;
            Array.Sort(A);
            var result = 0;
            for (int p = 0; p < A.Length - 2; p++)
            {
                for (int q = p + 1; q < A.Length - 1; q++)
                {
                    for (int r = q + 1; r < A.Length; r++)
                    {
                        if (A[p] + A[q] > A[r])
                            result++;
                        else
                            break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// time complexity: O(N ** 2) or O(N ** 3), task score: 81, correctness: 100, performance: 50
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution2(int[] A)
        {
            if (A.Length < 3) return 0;
            Array.Sort(A);
            var result = 0;
            for (int p = 0; p < A.Length - 2; p++)
            {
                for (int q = p + 1; q < A.Length - 1; q++)
                {
                    for (int r = A.Length - 1; r > q; r--)
                    {
                        if (A[p] + A[q] > A[r])
                        {
                            result += (r - q);
                            break;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// time complexity: O(N ** 2), task score: 100
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution3(int[] A)
        {
            Array.Sort(A);
            var result = 0;
            for (int p = 0; p < A.Length - 2; p++)
            {
                var q = p + 1;
                var r = q + 1;
                while (q < A.Length - 1)
                {
                    if (r < A.Length && A[p] + A[q] > A[r])
                        r++;
                    else
                    {
                        result += r - q - 1;
                        q++;
                    }
                }
            }
            return result;
        }
    }
}
