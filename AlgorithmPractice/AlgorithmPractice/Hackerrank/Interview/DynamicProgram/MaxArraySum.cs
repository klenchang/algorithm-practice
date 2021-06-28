using System;

namespace AlgorithmPractice.Hackerrank.Interview.DynamicProgram
{
    public class MaxArraySum
    {
        #region topic
        /*
        Given an array of integers, find the subset of non-adjacent elements with the maximum sum. 
        Calculate the sum of that subset. 
        It is possible that the maximum sum is 0, the case when all elements are negative. 

        Example.
        arr = [-2, 1, 3, -4, 5]
        The following subsets with more than 1 element exist. 
        These exclude the empty subset and single element subsets which are also valid.

        Subset      Sum
        [-2, 3, 5]   6
        [-2, 3]      1
        [-2, -4]    -6
        [-2, 5]      3
        [1, -4]     -3
        [1, 5]       6
        [3, 5]       8
        The maximum subset sum is 8. Note that any individual element is a subset as well.

        arr = [-2, -3, -1] => 0

        Constraints
        1 <= n <= 10 ** 5
        -10 ** 4 <= arr[i] <= 10 ** 4
         */
        #endregion

        public static int MaxSubsetSum(int[] arr)
        {
            if (arr.Length == 0)
                return 0;
            arr[0] = Math.Max(0, arr[0]);
            if (arr.Length == 1)
                return arr[0];
            arr[1] = Math.Max(arr[0], arr[1]);
            for (int i = 2; i < arr.Length; i++)
                arr[i] = Math.Max(arr[i - 1], arr[i] + arr[i - 2]);
            
            return arr[arr.Length - 1];
        }
    }
}
