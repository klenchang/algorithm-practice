using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting
{
    public class MergeSort
    {
        #region topic
        /*
        In an array, arr , the elements at indices i and j (where i < j) form an inversion 
        if arr[i] > arr[j]. In other words, inverted elements arr[i] and arr[j] are considered to 
        be "out of order". To correct an inversion, we can swap adjacent elements. 

        Given an array arr, return the number of inversions to sort the array.
        For example,
        arr = [2,4,1]
        2,4,1 => 2,1,4 => 1,2,4
        return 2.

        Constraints
        1 <= d <= 15
        1 <= n <= 10 ** 5
        1 <= arr[i] <= 10 ** 7
         */
        #endregion

        public static long CountInversions(List<int> arr)
        {
            return MergeSortFunction(arr.ToArray(), 0, arr.Count - 1);
        }

        public static long MergeSortFunction(int[] arr, int start, int end)
        {
            var mid = (start + end) / 2;
            long leftInver;
            long rightInver;
            if (start < end)
            {
                leftInver = MergeSortFunction(arr, start, mid);
                rightInver = MergeSortFunction(arr, mid + 1, end);
            }
            else
                return 0;

            var leftStart = start;
            var rightStart = mid + 1;
            var temp = new int[end - start + 1];
            var tempIndex = 0;
            long mergeInver = 0;
            while (leftStart <= mid && rightStart <= end)
            {
                if (arr[leftStart] > arr[rightStart])
                {
                    temp[tempIndex] = arr[rightStart];
                    mergeInver += mid - leftStart + 1;
                    rightStart++;
                }
                else
                {
                    temp[tempIndex] = arr[leftStart];
                    leftStart++;
                }
                tempIndex++;
            }
            if (leftStart != mid + 1)
            {
                while (leftStart <= mid)
                {
                    temp[tempIndex] = arr[leftStart];
                    leftStart++;
                    tempIndex++;
                }
            }
            if (rightStart != end + 1)
            {
                while (rightStart <= end)
                {
                    temp[tempIndex] = arr[rightStart];
                    rightStart++;
                    tempIndex++;
                }
            }
            Array.Copy(temp, 0, arr, start, temp.Length);
            return leftInver + rightInver + mergeInver;
        }
    }
}
