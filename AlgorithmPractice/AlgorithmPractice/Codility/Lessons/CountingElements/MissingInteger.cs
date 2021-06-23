using System;
using System.Linq;

namespace AlgorithmPractice.Codility.Lessons.CountingElements
{
    public class MissingInteger
    {
        #region topic
        /*
        This is a demo task.
        Write a function:
            
            class Solution { public int solution(int[] A); }
        
        that, given an array A of N integers, 
        returns the smallest positive integer (greater than 0) that does not occur in A.

        For example, 
            Given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            Given A = [1, 2, 3], the function should return 4.
            Given A = [−1, −3], the function should return 1.
        
        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000]. 

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
            var array = A.Where(n => n > 0).ToArray();
            if (!array.Any()) return 1;

            Array.Sort(array);
            if (array[0] != 1) return 1;

            var result = 0;
            for (int index = 0; index < array.Length - 1; index++)
            {
                if ((array[index + 1] - array[index]) > 1)
                {
                    result = array[index] + 1;
                    break;
                }
            }
            return result != 0 ? result : array[array.Length - 1] + 1;
        }

        /// <summary>
        ///  time complexity: O(N) or O(N * log(N))
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution2(int[] A)
        {
            var temp = new bool[1000000];
            for (int i = 0; i < A.Length; i++)
                if (A[i] > 0 && !temp[A[i] - 1])
                    temp[A[i] - 1] = true;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!temp[i])
                    return i + 1;
            }
            return A.Length + 1;
        }
    }
}
