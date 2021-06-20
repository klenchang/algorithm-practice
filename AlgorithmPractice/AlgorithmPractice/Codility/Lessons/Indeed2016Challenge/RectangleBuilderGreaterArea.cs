using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.Indeed2016Challenge
{
    public class RectangleBuilderGreaterArea
    {
        #region topic
        /*
        Halfling Woolly Proudhoof is an eminent sheep herder.
        He wants to build a pen (enclosure) for his new flock of sheep. 
        The pen will be rectangular and built from exactly four pieces of fence
        (so, the pieces of fence forming the opposite sides of the pen must be of equal length). 
        Woolly can choose these pieces out of N pieces of fence that are stored in his barn. 
        To hold the entire flock, the area of the pen must be greater than or equal to a given threshold X.

        Woolly is interested in the number of different ways in which he can build a pen. 
        Pens are considered different if the sets of lengths of their sides are different.
        For example, a pen of size 1×4 is different from a pen of size 2×2 (although both have an area of 4), 
        but pens of sizes 1×2 and 2×1 are considered the same.

        Write a function:

            class Solution { public int solution(int[] A, int X); }

        that, given an array A of N integers (containing the lengths of the available pieces of fence) and 
        an integer X, returns the number of different ways of building a rectangular pen satisfying 
        the above conditions. The function should return −1 if the result exceeds 1,000,000,000.

        For example, given X = 5 and the following array A:
          A[0] = 1
          A[1] = 2
          A[2] = 5
          A[3] = 1
          A[4] = 1
          A[5] = 2
          A[6] = 3
          A[7] = 5
          A[8] = 1
        the function should return 2. 
        The figure above shows available pieces of fence (on the left) and possible to build pens 
        (on the right). The pens are of sizes 1x5 and 2x5. Pens of sizes 1×1 and 1×2 can be built, 
        but are too small in area. It is not possible to build pens of sizes 2×3 or 3×5, 
        as there is only one piece of fence of length 3.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            X is an integer within the range [1..1,000,000,000];
            each element of array A is an integer within the range [1..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * log(N)) or O(N ** 2), Correctness = 94%, Performance = 66%, Task Score = 84%
        /// </summary>
        /// <param name="A"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static int Solution(int[] A, int X)
        {
            Array.Sort(A);
            var small = new List<int>();
            var big = new List<int>();
            var biggerThanSqrt = false;
            var sqrt = Math.Sqrt(X);
            var count = 0;
            long cnt = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= sqrt)
                {
                    if (i == 0 || A[i] != A[i - 1])
                        count = 1;
                    else
                    {
                        count++;
                        if (count == 4)
                            cnt++;
                    }
                }

                if (A[i] > sqrt && !biggerThanSqrt) biggerThanSqrt = true;
                if (i < A.Length - 1)
                {
                    if (A[i] == A[i + 1])
                    {
                        if (!biggerThanSqrt)
                        {
                            if (small.Count == 0 || small.Last() != A[i])
                                small.Add(A[i]);
                        }
                        else
                        {
                            if (big.Count == 0 || big.Last() != A[i])
                                big.Add(A[i]);
                        }
                    }
                }
            }
            if (big.Count == 0) return (int)cnt;
            else if (big.Count >= 2)
            {
                for (int i = 1; i <= big.Count - 1; i++)
                {
                    cnt += i;
                    if (cnt > 1000000000) return -1;
                }
            }

            for (var x = 0; x < small.Count; x++)
            {
                var current = small[x];
                var q = X / current;
                var r = X % current;
                var min = q;
                if (r != 0)
                    min ++;
                for (int y = 0; y < big.Count; y++)
                {
                    if (big[y] >= min)
                    {
                        cnt += (big.Count - y);
                        break;
                    }
                }
                if (cnt > 1000000000) return -1;
            }

            return (int)cnt;
        }
    }
}
