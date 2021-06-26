using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting
{
    public class LilysHomework
    {
        #region topic
        /*
        Whenever George asks Lily to hang out, she's busy doing homework. 
        George wants to help her finish it faster, but he's in over his head! 
        Can you help George understand Lily's homework so she can hang out with him? 

        Array is beautiful if sum of |array[i] - array[i-1]| is minimal.
        Given the array , determine and return the minimum number of swaps that should be performed 
        in order to make the array beautiful.

        For example.
        arr = [7,15,12,3], return 2. because
        original = [7, 15, 12,  3]
          swap 1 = [3, 15, 12,  7]
          swap 2 = [3,  7, 12, 15]

        Constraints
        1 <= n <= 10 ** 5
        1 <= arr[i] <= 2 * 10 ** 9
         */
        #endregion

        public static int Solution(List<int> arr)
        {
            // record all pairs of <value, index>
            var sortedDictForward = new SortedDictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
                sortedDictForward.Add(arr[i], i);

            // copy a same one for backward to use
            var sortedDictBackward = new SortedDictionary<int, int>(sortedDictForward);

            var sorted = arr.OrderBy(n => n).ToArray();

            // check forward, e.g. 3,4,2,5,1 => 1,2,3,4,5
            var swapForward = 0;
            var tempForward = new int[arr.Count];
            arr.CopyTo(tempForward);
            for (int i = 0; i < sorted.Count(); i++)
            {
                // compare with sorted value and check whether swap or not.
                var actual = tempForward[i];
                var expected = sorted[i];
                if (actual != expected)
                {
                    swapForward++;
                    sortedDictForward[actual] = sortedDictForward[expected];
                    tempForward[sortedDictForward[actual]] = actual;
                }
            }
            // check backward, e.g. 3,4,2,5,1 => 5,4,3,2,1
            var swapBackward = 0;
            var tempBackward = new int[arr.Count];
            arr.CopyTo(tempBackward);
            for (int i = 0; i < sorted.Count(); i++)
            {
                // compare with sorted value and check whether swap or not.
                var actual = tempBackward[i];
                var expected = sorted[sorted.Length - 1 - i];
                if (actual != expected)
                {
                    swapBackward++;
                    sortedDictBackward[actual] = sortedDictBackward[expected];
                    tempBackward[sortedDictBackward[actual]] = actual;
                }
            }

            return Math.Min(swapForward, swapBackward);
        }
    }
}
