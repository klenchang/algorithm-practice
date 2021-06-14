using System;

namespace AlgorithmPractice.Codility.Lessons.PrefixSums
{
    public class MushroomPicker
    {
        #region topic
        /*
        For example, consider array A such that:
            2 3 7 5 1 3 9
        
        The mushroom picker starts at spot k = 4 and should perform m = 6 moves. 
        She might move to spots 3, 2, 3, 4, 5, 6 and thereby collect 1 + 5 + 7 + 3 + 9 = 25 mushrooms. 
        This is the maximal number of mushrooms she can collect. 

        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
         */
        #endregion

        public static int Solution(int[] a, int k, int m)
        {
            int[] prefix = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++) prefix[i + 1] = prefix[i] + a[i];
            int res = 0;
            for (int i = 0; i < Math.Min(m, k) + 1; i++)
            {
                int left = k - i;
                int right = Math.Min(Math.Max(k + m - 2 * i, k), a.Length - 1);
                res = Math.Max(res, prefix[right + 1] - prefix[left]);
            }
            for (int i = 0; i < Math.Min(a.Length - k, m + 1); i++)
            {
                int left = Math.Max(0, Math.Min(k - (m - 2 * i), k));
                int right = k + i;
                res = Math.Max(res, prefix[right + 1] - prefix[left]);
            }
            return res;
        }
    }
}
