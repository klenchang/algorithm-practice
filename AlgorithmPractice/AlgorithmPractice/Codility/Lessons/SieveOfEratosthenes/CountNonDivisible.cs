using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.SieveOfEratosthenes
{
    public class CountNonDivisible
    {
        #region topic
        /*
        You are given an array A consisting of N integers.

        For each number A[i] such that 0 ≤ i < N, 
        we want to count the number of elements of the array 
        that are not the divisors of A[i]. We say that these elements are non-divisors.

        For example, consider integer N = 5 and array A such that:
            A[0] = 3
            A[1] = 1
            A[2] = 2
            A[3] = 3
            A[4] = 6
        For the following elements:
        A[0] = 3, the non-divisors are: 2, 6,
        A[1] = 1, the non-divisors are: 3, 2, 3, 6,
        A[2] = 2, the non-divisors are: 3, 3, 6,
        A[3] = 3, the non-divisors are: 2, 6,
        A[4] = 6, there aren't any non-divisors.
        Write a function:

            class Solution { public int[] solution(int[] A); }

        that, given an array A consisting of N integers, \
        returns a sequence of integers representing the amount of non-divisors.

        Result array should be returned as an array of integers.

        For example, given:
            A[0] = 3
            A[1] = 1
            A[2] = 2
            A[3] = 3
            A[4] = 6
        the function should return [2, 4, 3, 2, 0], as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..50,000];
            each element of array A is an integer within the range [1..2 * N].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * log(N))
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] Solution(int[] A)
        {
            // store count for each number
            var array = new int[100000];
            foreach (var n in A)
                array[n - 1]++;

            var result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                // find divosors of A[i]
                var sqrt = (int)Math.Sqrt(A[i]);
                Queue<int> queue = new Queue<int>();
                for (int n = sqrt; n >= 1; n--)
                {
                    if (A[i] % n == 0)
                    {
                        queue.Enqueue(n);
                        var quotient = A[i] / n;
                        if (n != quotient)
                            queue.Enqueue(quotient);
                    }
                }
                // caculate total count of all divisors
                var divisorNums = 0;
                while (queue.Count != 0)
                    divisorNums += array[queue.Dequeue() - 1];

                // non-divisor count = total numbers - 1's count - its count - total divisors count
                result[i] = A.Length - divisorNums;
            }

            return result;
        }

        public class SolutionWithHashHistory
        {
            public int[] Solution(int[] A)
            {
                if (A.Length == 1)
                    return new[] { 0 };
                var data = GetNumbersOfElement(A);
                var totalCount = A.Length;
                var res = new int[A.Length];
                var history = new Dictionary<int, int>();
                for (int i = 0; i < res.Length; i++)
                    res[i] = totalCount - FindFactorCount(A[i], data, history);

                return res;
            }
            private int[] GetNumbersOfElement(int[] A)
            {
                var res = new int[A.Length * 2];
                foreach (var n in A)
                    res[n - 1]++;
                return res;
            }
            private int FindFactorCount(int n, int[] data, Dictionary<int, int> history)
            {
                if (history.ContainsKey(n))
                    return history[n];

                var sqrt = (int)Math.Sqrt(n);
                var count = 0;
                for (int i = sqrt; i >= 1; i--)
                {
                    if (n % i == 0)
                    {
                        var q = n / i;
                        count += data[i - 1];
                        if (i != q)
                            count += data[q - 1];
                    }
                }
                history.Add(n, count);
                return count;
            }
        }
    }
}
