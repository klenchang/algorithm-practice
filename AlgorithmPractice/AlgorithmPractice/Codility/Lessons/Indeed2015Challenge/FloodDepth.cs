using System;

namespace AlgorithmPractice.Codility.Lessons.Indeed2015Challenge
{
    public class FloodDepth
    {
        #region topic
        /*
        You are helping a geologist friend investigate an area with mountain lakes. 
        A recent heavy rainfall has flooded these lakes and their water levels 
        have reached the highest possible point. 
        Your friend is interested to know the maximum depth in the deepest part of 
        these lakes.

        We simplify the problem in 2-D dimensions. 
        The whole landscape can be divided into small blocks and described by an array 
        A of length N. Each elemen
        t of A is the altitude of the rock floor of a block 
        (i.e. the height of this block when there is no water at all). 
        After the rainfall, all the low-lying areas
        (i.e. blocks that have higher blocks on both sides) are holding as much water 
        as possible. You would like to know the maximum depth of water 
        after this entire area is flooded. 
        You can assume that the altitude outside this area is zero and the outside area 
        can accommodate infinite amount of water.

        For example, consider array A such that:
            A[0] = 1
            A[1] = 3
            A[2] = 2
            A[3] = 1
            A[4] = 2
            A[5] = 1
            A[6] = 5
            A[7] = 3
            A[8] = 3
            A[9] = 4
            A[10] = 2
        The following picture illustrates the landscape after it has flooded:

        The gray area is the rock floor described by the array A above and 
        the blue area with dashed lines represents the water filling the low-lying areas 
        with maximum possible volume. 
        Thus, blocks 3 and 5 have a water depth of 2 while blocks 2, 4, 7 and 8 
        have a water depth of 1. Therefore, the maximum water depth of this area is 2.

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N integers, 
        returns the maximum depth of water.

        Given array A shown above, the function should return 2, as explained above.

        For the following array:
            A[0] = 5
            A[1] = 8
        the function should return 0, because this landscape cannot hold any water.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [1..100,000,000].
        
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
            if (A.Length < 3) return 0;
            var dpLeft = new int[A.Length];
            dpLeft[0] = A[0];
            dpLeft[A.Length - 1] = A[A.Length - 1];
            for (int i = 1; i < A.Length - 1; i++)
                dpLeft[i] = Math.Max(dpLeft[i - 1], A[i]);

            var dpRight = new int[A.Length];
            dpRight[0] = A[0];
            dpRight[A.Length - 1] = A[A.Length - 1];
            for (int i = A.Length - 2; i >= 1; i--)
                dpRight[i] = Math.Max(dpRight[i + 1], A[i]);

            var maxDepth = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                var currentDepth = Math.Min(dpLeft[i], dpRight[i]) - A[i];
                if (currentDepth > maxDepth)
                    maxDepth = currentDepth;
            }
            return maxDepth;
        }
    }
}
