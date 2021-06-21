using System;

namespace AlgorithmPractice.Codility.Lessons.FutureTraining
{
    public class ArrayInversionCount
    {
        #region topic
        /*
        An array A consisting of N integers is given. 
        An inversion is a pair of indexes (P, Q) such that P < Q and A[Q] < A[P].

        Write a function:

            class Solution { public int solution(int[] A); }

        that computes the number of inversions in A, or returns −1 if it exceeds 1,000,000,000.

        For example, in the following array:
         A[0] = -1 A[1] = 6 A[2] = 3
         A[3] =  4 A[4] = 7 A[5] = 4
        there are four inversions:
           (1,2)  (1,3)  (1,5)  (4,5)
        so the function should return 4.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
        
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
            return MergeSort(A, 0, A.Length - 1);
        }
        public static int MergeSort(int[] A, int first, int last)
        {
            var mid = (first + last) / 2;
            int leftInver;
            int rightInver;
            if (first < last)
            {
                leftInver = MergeSort(A, first, mid);
                if (leftInver == -1) return -1;
                rightInver = MergeSort(A, mid + 1, last);
                if (rightInver == -1) return -1;
            }
            else return 0;

            var firstIndex = first;
            var secondIndex = mid + 1;
            var temp = new int[last - first + 1];
            var tempIndex = 0;
            var mergeInver = 0;
            while (firstIndex <= mid && secondIndex <= last)
            {
                if (A[firstIndex] <= A[secondIndex])
                {
                    temp[tempIndex] = A[firstIndex];
                    firstIndex++;
                }
                else
                {
                    temp[tempIndex] = A[secondIndex];
                    secondIndex++;
                    mergeInver += mid - firstIndex + 1;
                    if (mergeInver > 1000000000) return -1;
                }
                tempIndex++;
            }
            if (firstIndex != mid + 1)
            {
                while (firstIndex <= mid)
                {
                    temp[tempIndex] = A[firstIndex];
                    firstIndex++;
                    tempIndex++;
                }
            }
            if (secondIndex != last + 1)
            {
                while (secondIndex <= last)
                {
                    temp[tempIndex] = A[secondIndex];
                    secondIndex++;
                    tempIndex++;
                }
            }
            Array.Copy(temp, 0, A, first, last + 1 - first);
            if (mergeInver + leftInver + rightInver > 1000000000)
                return -1;
            else
                return mergeInver + leftInver + rightInver;
        }
    }
}
