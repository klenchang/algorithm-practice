namespace AlgorithmPractice.Codility.Lessons.Sorting
{
    public class NumberOfDiscIntersections
    {
        #region topic
        /*
        We draw N discs on a plane. The discs are numbered from 0 to N − 1. 
        An array A of N non-negative integers, specifying the radiuses of the discs, is given. 
        The J-th disc is drawn with its center at (J, 0) and radius A[J].

        We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs 
        have at least one common point (assuming that the discs contain their borders).

        The figure below shows discs drawn for N = 6 and A as follows:
          A[0] = 1
          A[1] = 5
          A[2] = 2
          A[3] = 1
          A[4] = 4
          A[5] = 0
        There are eleven (unordered) pairs of discs that intersect, namely:
            discs 1 and 4 intersect, and both intersect with all the other discs;
            disc 2 also intersects with discs 0 and 3.
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A describing N discs as explained above, 
        returns the number of (unordered) pairs of intersecting discs. 
        The function should return −1 if the number of intersecting pairs exceeds 10,000,000.
        Given array A shown above, the function should return 11, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [0..100,000];
            each element of array A is an integer within the range [0..2,147,483,647].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N ** 2)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution1(int[] A)
        {
            if (A.Length == 0) return 0;
            long result = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    long distance = j - i;
                    long radiusSum = (long)A[i] + (long)A[j];
                    if (distance <= radiusSum)
                        result++;
                }
            }
            return result > 10000000 ? -1 : (int)result;
        }

        /// <summary>
        /// time complexity: O(N * log(N)) or O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution2(int[] A)
        {
            var inArray = new ushort[A.Length];
            var outArray = new ushort[A.Length];
            for (int index = 0; index < A.Length; index++)
            {
                var indexOfInArray = index - A[index] < 0 ? 0 : index - A[index];
                inArray[indexOfInArray]++;
                // A[index] + index < 0 => over max number of integer
                var indexOfOutArray = A[index] + index > A.Length - 1 || A[index] + index < 0 ? A.Length - 1 : A[index] + index;
                outArray[indexOfOutArray]++;
            }
            var activeCircles = 0;
            var intersectionTimes = 0;
            for (int index = 0; index < inArray.Length; index++)
            {
                if (inArray[index] > 0)
                {
                    // intersect with circles that cover this spot before
                    intersectionTimes += activeCircles * inArray[index];
                    // intersection between new circles that left spot is this spot
                    // N circles will intersect N * (N-1) / 2
                    intersectionTimes += inArray[index] * (inArray[index] - 1) / 2;
                    if (intersectionTimes > 10000000) return -1;
                }
                // activeCircle equal old active circles add new circles minus inactive circles
                // inactive circles means right spot is this spot
                activeCircles = activeCircles + inArray[index] - outArray[index];
            }
            return intersectionTimes;
        }
    }
}
