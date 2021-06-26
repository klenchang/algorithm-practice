using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Hackerrank.Interview.Arrays
{
    public class ArrayManipulation
    {
        #region topic
        /*
        Starting with a 1-indexed array of zeros and a list of operations, 
        for each operation add a value to each the array element between two given indices, inclusive. 
        Once all operations have been performed, return the maximum value in the array. 

        Example
        n = 10
        queries = [[1,5,3],[4,8,7],[6,9,1]]

        a b k
        1 5 3
        4 8 7
        6 9 1
            
             n | 1 2 3  4  5 6 7 8 9 10
        result | 0 0 0  0  0 0 0 0 0  0
        step 1 | 3 3 3  3  3 0 0 0 0  0
        step 2 | 3 3 3 10 10 7 7 7 0  0
        step 3 | 3 3 3 10 10 8 8 8 1  0

        write a function to return max result;
        for above example, return 10;

        Constraints
        3 <= n <= 10 ** 7
        1 <= m <= 2 * 10 ** 5
        1 <= a <= b <= n
        0 <= k <= 10 ** 9
         */
        #endregion

        /// <summary>
        /// refer to https://josephjsf2.github.io/hackerrank/2020/01/27/array-manipulation.html
        /// Don't caculate for every element. 
        /// To record start element and every difference between two adjacent elements
        /// so for n = 10, queries = [[1,5,3],[4,8,7],[6,9,1]]
        ///      n | 1 2 3  4  5  6 7 8  9 10
        /// result | 0 0 0  0  0  0 0 0  0  0
        /// step 1 | 3 0 0  0  0 -3 0 0  0  0
        /// step 2 | 3 0 0  7  0 -3 0 0 -7  0
        /// step 3 | 3 0 0  7  0 -2 0 0 -7 -1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static long ArrayManipulationFunction(int n, List<List<int>> queries)
        {
            var temp = new long[n];
            foreach (var q in queries)
            {
                var start = q[0] - 1;
                var end = q[1];
                var increase = (long)q[2];
                temp[start] += increase;
                if (end < n)
                    temp[end] -= increase;
            }
            long max = 0;
            long sum = 0;
            foreach (var number in temp)
            {
                sum += number;
                if (sum > max)
                    max = sum;
            }
            return max;
        }
    }
}
