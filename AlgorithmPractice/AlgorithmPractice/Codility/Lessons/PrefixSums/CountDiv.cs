namespace AlgorithmPractice.Codility.Lessons.PrefixSums
{
    public class CountDiv
    {
        #region topic
        /*
        Write a function:
        
            class Solution { public int solution(int A, int B, int K); }
        
        that, given three integers A, B and K, 
        returns the number of integers within the range [A..B] that are divisible by K, 
        i.e.:
            { i : A ≤ i ≤ B, i mod K = 0 }
        
        For example, for A = 6, B = 11 and K = 2, your function should return 3, 
        because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.
        
        Write an efficient algorithm for the following assumptions:
            A and B are integers within the range [0..2,000,000,000];
            K is an integer within the range [1..2,000,000,000];
            A ≤ B. 

        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
         */
        #endregion

        /// <summary>
        /// time complexity: O(B - A)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int Solution(int A, int B, int K)
        {
            var count = 0;
            for (int n = A; n <= B; n++)
                if (n % K == 0)
                    count++;
            return count;
        }

        /// <summary>
        /// time complexity: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int Solution2(int A, int B, int K)
        {
            var quotientA = A / K;
            var remainderA = A % K;
            var quotientB = B / K;

            return quotientB - quotientA + (remainderA == 0 ? 1 : 0);
        }
    }
}
