using System;

namespace AlgorithmPractice.Codility.Lessons.SieveOfEratosthenes
{
    public class CountSemiprimes
    {
        #region topic
        /*
        A prime is a positive integer X that has exactly two distinct divisors: 1 and X. 
        The first few prime integers are 2, 3, 5, 7, 11 and 13.

        A semiprime is a natural number that is the product of two (not necessarily distinct) 
        prime numbers. 
        The first few semiprimes are 4, 6, 9, 10, 14, 15, 21, 22, 25, 26.

        You are given two non-empty arrays P and Q, each consisting of M integers. 
        These arrays represent queries about the number of semiprimes within specified ranges.

        Query K requires you to find the number of semiprimes within the range (P[K], Q[K]), 
        where 1 ≤ P[K] ≤ Q[K] ≤ N.

        For example, consider an integer N = 26 and arrays P, Q such that:
            P[0] = 1    Q[0] = 26
            P[1] = 4    Q[1] = 10
            P[2] = 16   Q[2] = 20
        The number of semiprimes within each of these ranges is as follows:
            (1, 26) is 10,
            (4, 10) is 4,
            (16, 20) is 0.
        Write a function:

            class Solution { public int[] solution(int N, int[] P, int[] Q); }

        that, given an integer N and two non-empty arrays P and Q consisting of M integers, 
        returns an array consisting of M elements specifying the consecutive answers to all the queries.

        For example, given an integer N = 26 and arrays P, Q such that:
            P[0] = 1    Q[0] = 26
            P[1] = 4    Q[1] = 10
            P[2] = 16   Q[2] = 20
        the function should return the values [10, 4, 0], as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..50,000];
            M is an integer within the range [1..30,000];
            each element of arrays P, Q is an integer within the range [1..N];
            P[i] ≤ Q[i].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * log(log(N)) + M * N) or O(M * N ** (3/2))
        /// task score: 66%, correctness: 100%, performance: 40%
        /// </summary>
        /// <param name="N"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int[] Solution1(int N, int[] P, int[] Q)
        {
            var f = new int[N + 1];
            for (int x = 2; x <= N; x++)
                if (f[x] == 0)
                    for (int y = x; y <= N; y += x)
                        if (y % (x * x) == 0)
                            f[y] = (f[y] == 0 ? f[y / x / x] : f[y]) + 2;
                        else if (y % x == 0)
                            f[y]++;

            var result = new int[P.Length];
            for (int i = 0; i < result.Length; i++)
                for (var x = P[i]; x <= Q[i]; x++)
                    if (f[x] == 2)
                        result[i]++;

            return result;
        }

        /// <summary>
        /// time complexity: O(N * log(log(N)) + M), task score: 100%
        /// </summary>
        /// <param name="N"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int[] Solution2(int N, int[] P, int[] Q)
        {
            var sieve = Sieve(N);
            var semiPrime = Semiprime(sieve);
            var semiPrimePrefixSum = SemiPrimePrefixSum(semiPrime);

            var res = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
                res[i] = semiPrimePrefixSum[Q[i]] - semiPrimePrefixSum[P[i] - 1];

            return res;
        }
        public static int[] Sieve(int N)
        {
            var sieve = new int[N + 1];
            for (int i = 2; i <= (int)Math.Sqrt(N); i++)
            {
                if (sieve[i] == 0)
                {
                    var k = i * i;
                    while (k <= N)
                    {
                        if (sieve[k] == 0)
                            sieve[k] = i;
                        k += i;
                    }
                }
            }
            return sieve;
        }
        public static int[] Semiprime(int[] sieve)
        {
            var semiPrime = new int[sieve.Length];
            for (int i = 0; i < sieve.Length; i++)
            {
                if (sieve[i] == 0) continue;
                int firstFactor = sieve[i];
                if (sieve[i / firstFactor] == 0) semiPrime[i] = 1;
            }
            return semiPrime;
        }
        public static int[] SemiPrimePrefixSum(int[] semiPrime)
        {
            var prefix = new int[semiPrime.Length];
            for (int i = 1; i < prefix.Length; i++)
            {
                prefix[i] = prefix[i - 1] + semiPrime[i];
            }
            return prefix;
        }
    }
}
