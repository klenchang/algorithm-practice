using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.Leader
{
    public class Dominator
    {
        #region topic
        /*
        An array A consisting of N integers is given.
        The dominator of array A is the value that occurs in more than half of the elements of A.

        For example, consider array A such that
            A[0] = 3    A[1] = 4    A[2] =  3
            A[3] = 2    A[4] = 3    A[5] = -1
            A[6] = 3    A[7] = 3
        The dominator of A is 3 because it occurs in 5 out of 8 elements of A 
        (namely in those with indices 0, 2, 4, 6 and 7) and 5 is more than a half of 8.
        
        Write a function

            class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, 
        returns index of any element of array A in which the dominator of A occurs. 
        The function should return −1 if array A does not have a dominator.

        For example, given array A such that
            A[0] = 3    A[1] = 4    A[2] =  3
            A[3] = 2    A[4] = 3    A[5] = -1
            A[6] = 3    A[7] = 3
        the function may return 0, 2, 4, 6 or 7, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        ///  time complexity: O(N * log(N)) or O(N)
        /// if we remove two different elements then only one of them could be the leader.
        /// The leader in thenew sequence occurs more than n /2 − 1 = n−2 / 2 times.Consequently, 
        /// it is still the leader of the new sequence of n − 2 elements.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            var stack = new Stack<int>();
            var index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (stack.Count == 0 || stack.Peek() == A[i])
                { 
                    stack.Push(A[i]);
                    index = i;
                }
                else if (stack.Peek() != A[i])
                    stack.Pop();
            }
            if (stack.Count == 0) return -1;
            var candidate = stack.Peek();
            var count = 0;
            foreach (var n in A)
                if (candidate == n) count ++;

            return count > A.Length / 2 ? index : -1;
        }

    }
}
