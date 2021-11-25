﻿namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers
{
    public class FibFrog
    {
        #region topic
        /*
        The Fibonacci sequence is defined using the following recursive formula:
            F(0) = 0
            F(1) = 1
            F(M) = F(M - 1) + F(M - 2) if M >= 2
        A small frog wants to get to the other side of a river. 
        The frog is initially located at one bank of the river (position −1) 
        and wants to get to the other bank (position N). 
        The frog can jump over any distance F(K), where F(K) is the K-th Fibonacci number. 
        Luckily, there are many leaves on the river, 
        and the frog can jump between the leaves, 
        but only in the direction of the bank at position N.

        The leaves on the river are represented in an array A consisting of N integers. 
        Consecutive elements of array A represent consecutive positions 
        from 0 to N − 1 on the river. Array A contains only 0s and/or 1s:
            0 represents a position without a leaf;
            1 represents a position containing a leaf.
        The goal is to count the minimum number of jumps in which the frog can get to the other side of the river (from position −1 to position N). 
        The frog can jump between positions −1 and N (the banks of the river) and every position containing a leaf.

        For example, consider array A such that:
            A[0] = 0
            A[1] = 0
            A[2] = 0
            A[3] = 1
            A[4] = 1
            A[5] = 0
            A[6] = 1
            A[7] = 0
            A[8] = 0
            A[9] = 0
            A[10] = 0
        The frog can make three jumps of length F(5) = 5, F(3) = 2 and F(5) = 5.

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns the minimum number of jumps by 
        which the frog can get to the other side of the river. 
        If the frog cannot reach the other side of the river, 
        the function should return −1.

        For example, given:
            A[0] = 0
            A[1] = 0
            A[2] = 0
            A[3] = 1
            A[4] = 1
            A[5] = 0
            A[6] = 1
            A[7] = 0
            A[8] = 0
            A[9] = 0
            A[10] = 0
        the function should return 3, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer that can have one of the following values: 0, 1.
        
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
            var fx = Common.GetFibonacciList(A.Length + 1);
            int result = -1;
            for (int i = 0; i <= A.Length; i++)
            {
                if (i == A.Length || A[i] == 1) // destination is A.Length
                {
                    var steps = 0;
                    for (int j = 2; j < fx.Length && fx[j] <= i + 1; j++)
                    {
                        // check whether can jump from this point and caculate steps
                        var start = i - fx[j];
                        if (start == -1) // from starting point
                            steps = 1;
                        else if (A[start] >= 1)
                        {
                            // don't update steps as this line, performance is too slow
                            // steps = (steps == 0 ? A[start] : Math.Min(steps, A[start])) + 1;
                            if (steps == 0 || A[start] + 1 < steps)
                                steps = A[start] + 1;
                        }
                    }
                    // update steps
                    if (i != A.Length) // update every point
                        A[i] = steps;
                    else if (steps > 0) // update end point
                        result = steps;
                }
            }

            return result;
        }
    }
}
