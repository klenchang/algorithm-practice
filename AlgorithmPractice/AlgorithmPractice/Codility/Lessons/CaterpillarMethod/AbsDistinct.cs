using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.CaterpillarMethod
{
    public class AbsDistinct
    {
        #region topic
        /*
        A non-empty array A consisting of N numbers is given. 
        The array is sorted in non-decreasing order. 
        The absolute distinct count of this array is the number of distinct 
        absolute values among the elements of the array.

        For example, consider array A such that:
          A[0] = -5
          A[1] = -3
          A[2] = -1
          A[3] =  0
          A[4] =  3
          A[5] =  6
        The absolute distinct count of this array is 5, 
        because there are 5 distinct absolute values among the elements of this array, 
        namely 0, 1, 3, 5 and 6.

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N numbers, 
        returns absolute distinct count of array A.

        For example, given array A such that:
          A[0] = -5
          A[1] = -3
          A[2] = -1
          A[3] =  0
          A[4] =  3
          A[5] =  6
        the function should return 5, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−2,147,483,648..2,147,483,647];
            array A is sorted in non-decreasing order.
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N) or O(N * log(N))
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            if (A.Length == 1) return 1;

            var negativeStack = new Stack<int>();
            var positiveQueue = new Queue<int>();
            var lastPositiveNumber = -1;
            foreach (var n in A)
            {
                if (n < 0)
                {
                    if (negativeStack.Count == 0 || negativeStack.Peek() != n)
                        negativeStack.Push(n);
                }
                else
                {
                    if (positiveQueue.Count == 0 || lastPositiveNumber != n)
                    {
                        positiveQueue.Enqueue(n);
                        lastPositiveNumber = n;
                    }
                }
            }

            var count = 0;
            while (negativeStack.Count != 0 && positiveQueue.Count != 0)
            {
                var sum = negativeStack.Peek() + positiveQueue.Peek();
                count++;
                if (sum == 0)
                {
                    negativeStack.Pop();
                    positiveQueue.Dequeue();
                }
                else if (sum < 0)
                    positiveQueue.Dequeue();
                else
                    negativeStack.Pop();
            }

            return count + negativeStack.Count + positiveQueue.Count;
        }

        /// <summary>
        ///  time complexity: O(N) or O(N * log(N))
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution2(int[] A)
        {
            var head = 0;
            var tail = A.Length - 1;
            // because Math.Abs(int.MinValue) will throw error, we need to process it specially
            var currentAbs = A[0] == int.MinValue ? int.MinValue : Math.Max(Math.Abs(A[head]), Math.Abs(A[tail]));
            var result = 1;
            while (head <= tail)
            {
                if (currentAbs == int.MinValue)
                {
                    if (A[head] == currentAbs)
                        head++;
                    else
                    {
                        result++;
                        currentAbs = Math.Max(Math.Abs(A[head]), Math.Abs(A[tail]));
                    }
                }
                else if (Math.Abs(A[head]) != currentAbs && Math.Abs(A[tail]) != currentAbs)
                {
                    result++;
                    currentAbs = Math.Max(Math.Abs(A[head]), Math.Abs(A[tail]));
                }
                else if (Math.Abs(A[head]) == currentAbs)
                    head++;
                else if (Math.Abs(A[tail]) == currentAbs)
                    tail--;
            }

            return result;
        }
    }
}
