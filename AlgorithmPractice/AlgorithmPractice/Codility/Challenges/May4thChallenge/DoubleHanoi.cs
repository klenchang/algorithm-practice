using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Challenges.May4thChallenge
{
    public class DoubleHanoi
    {
        #region topic
        /*
        You are given N disks and two rods, each with one initial disk.

        On the left rod, disks can be placed in decreasing order of size
        (smaller disks on top of bigger ones). On the right rod, 
        disks can be placed in increasing order of size (bigger disks on top of smaller ones). 
        Note that it is not permissible to place two disks of equal size on top of each other. 
        The initial disks cannot be moved.

        "Image of two hanoi towers, each with three disks."

        Write a function:

            class Solution { public int solution(int[] A, int L, int R); }

        that, given an array A of integers representing the sizes of the N disks and 
        two integers L and R representing the size of the initial disks on the left and 
        right rods respectively, returns the maximum number of disks from A that can be 
        placed on the rods while satisfying the rules presented above.

        Examples:

        1. Given A = [2, 3, 3, 4], L = 3 and R = 1, 
        your function should return 3, since only three disks can be placed on the rods. 
        Note that the disk of size 2 can be placed on either the left rod or the right rod.

        "Graphical representation of first solution to example 1."

        "Graphical representation of second solution to example 1."

        2. Given A = [1, 4, 5, 5], L = 6 and R = 4, your function should return 4.

        "Graphical representation of second solution to example 2."

        3. Given A = [5, 2, 5, 2], L = 8 and R = 1, your function should return 4.

        "Graphical representation of second solution to example 3."

        4. Given A = [1, 5, 5], L = 2 and R = 4, your function should return 2.

        "Graphical representation of second solution to example 4."

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..50,000];
            each element of array A is an integer within the range [1..1,000,000,000];
            L and R are integers within the range [1..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N * log(N)) or O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static int Solution(int[] A, int L, int R)
        {
            Array.Sort(A);
            var stackL = new Stack<int>();
            stackL.Push(L);
            for (int x = A.Length - 1; x >= 0; x--)
            {
                if (stackL.Peek() > A[x])
                {
                    stackL.Push(A[x]);
                    A[x] = -1;
                }
            }
            var stackR = new Stack<int>();
            stackR.Push(R);
            for (int x = 0; x < A.Length; x++)
            {
                if (A[x] > stackR.Peek())
                {
                    stackR.Push(A[x]);
                    A[x] = -1;
                }
            }
            return stackL.Count + stackR.Count - 2;
        }
    }
}
