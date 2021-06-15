using System;

namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm
{
    public class CommonPrimeDivisors
    {
        #region topic
        /*
        A prime is a positive integer X that has exactly two distinct divisors: 1 and X. 
        The first few prime integers are 2, 3, 5, 7, 11 and 13.

        A prime D is called a prime divisor of a positive integer P 
        if there exists a positive integer K such that D * K = P. 
        For example, 2 and 5 are prime divisors of 20.

        You are given two positive integers N and M. 
        The goal is to check whether the sets of prime divisors of integers N 
        and M are exactly the same.

        For example, given:
            N = 15 and M = 75, the prime divisors are the same: {3, 5};
            N = 10 and M = 30, the prime divisors aren't the same: {2, 5} is not equal to {2, 3, 5};
            N = 9 and M = 5, the prime divisors aren't the same: {3} is not equal to {5}.
        Write a function:

            class Solution { public int solution(int[] A, int[] B); }

        that, given two non-empty arrays A and B of Z integers, 
        returns the number of positions K for which the prime 
        divisors of A[K] and B[K] are exactly the same.

        For example, given:
            A[0] = 15   B[0] = 75
            A[1] = 10   B[1] = 30
            A[2] = 3    B[2] = 5
        the function should return 1, 
        because only one pair (15, 75) has the same set of prime divisors.

        Write an efficient algorithm for the following assumptions:
            Z is an integer within the range [1..6,000];
            each element of arrays A, B is an integer within the range [1..2,147,483,647].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(Z * log(max(A) + max(B)) ** 2)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int Solution(int[] A, int[] B)
        {
            var count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (CheckPrimesASameWithB(A[i], B[i]))
                    count++;
            }
            return count;
        }

        public static bool CheckPrimesASameWithB(int n, int m)
        {
            var gcd = Common.GCD(Math.Max(n, m), Math.Min(n, m));
            // check N's all primes are same with gcd's primes
            var same = CheckPrimesSameWithGCD(n, gcd);
            if (!same) return same;
            // check M's all primes are same with gcd's primes
            same = CheckPrimesSameWithGCD(m, gcd);

            return same;
        }

        public static bool CheckPrimesSameWithGCD(int n, int gcd)
        {
            n /= gcd;
            var gcdTemp = 0;
            while (n != 1 && gcdTemp != 1)
            {
                gcdTemp = Common.GCD(Math.Max(n, gcd), Math.Min(n, gcd));
                n /= gcdTemp;
            }
            return n == 1;
        }
    }
}
