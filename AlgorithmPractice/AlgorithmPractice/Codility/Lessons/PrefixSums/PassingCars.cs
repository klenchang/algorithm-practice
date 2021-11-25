using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.PrefixSums
{
    public class PassingCars
    {
        #region topic
        /*
        A non-empty array A consisting of N integers is given. 
        The consecutive elements of array A represent consecutive cars on a road.

        Array A contains only 0s and/or 1s:
            0 represents a car traveling east,
            1 represents a car traveling west.
        
        The goal is to count passing cars. 
        We say that a pair of cars (P, Q), 
        where 0 ≤ P < Q < N, is passing when P is traveling to the east 
        and Q is traveling to the west.

        For example, consider array A such that:
          A[0] = 0
          A[1] = 1
          A[2] = 0
          A[3] = 1
          A[4] = 1
        We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given a non-empty array A of N integers, returns the number of pairs of passing cars.
        The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.

        For example, given:
          A[0] = 0
          A[1] = 1
          A[2] = 0
          A[3] = 1
          A[4] = 1
        the function should return 5, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer that can have one of the following values: 0, 1.
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        ///  time complexity: O (N ** 2)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution1(int[] A)
        {
            var dict = new Dictionary<int, int>();
            for (var index = A.Length - 1; index >= 0; index--)
            {
                if (A[index] == 0)
                {
                    if (dict.Count == 0)
                    {
                        // last zero
                        dict.Add(index, A.Length - index - 1);
                    }
                    else
                    {
                        var previousZeroElement = dict.Last();
                        var count = (previousZeroElement.Key - index - 1) + previousZeroElement.Value;
                        dict.Add(index, count);
                    }
                }
            }
            var result = dict.Sum(kv => (long)kv.Value);

            return result > 1000000000 ? -1 : (int)result;
        }

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution2(int[] A)
        {
            var previousIndex = A.Length;
            long previousCount = 0;
            long total = 0;
            for (int index = A.Length - 1; index >= 0; index--)
            {
                if (A[index] == 0)
                {
                    // interval count + previous count
                    var currentCount = previousIndex - index - 1 + previousCount;
                    total += currentCount;
                    previousIndex = index;
                    previousCount = currentCount;
                }
            }
            return total > 1000000000 ? -1 : (int)total;
        }

        /// <summary>
        /// time complexity: O(N), use prefix sum
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution3(int[] A)
        {
            var prefixSum = new long[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
                prefixSum[i + 1] = prefixSum[i] + A[i];

            long total = 0;
            for (int i = 0; i < prefixSum.Length - 1; i++)
                if (prefixSum[i] == prefixSum[i + 1])
                    total += prefixSum[prefixSum.Length - 1] - prefixSum[i];

            return total > 1000000000 ? -1 : (int)total;
        }

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution4(int[] A)
        {
            var preSum = new long[A.Length + 1];
            long countZero = 0;
            for (int i = 0; i < A.Length; i++)
            {
                preSum[i + 1] = preSum[i];
                if (A[i] == 0)
                    countZero++;
                else
                    preSum[i + 1] += countZero;
            }
            return preSum[preSum.Length - 1] > 1000000000 ? -1 : (int)preSum[preSum.Length - 1];
        }
    }
}
