using System;

namespace AlgorithmPractice.Codility.Lessons.PrimeAndCompositeNumbers
{
    public class MinPerimeterRectangle
    {
        #region topic
        /*
        An integer N is given, representing the area of some rectangle.
        The area of a rectangle whose sides are of length A and B is A * B, 
        and the perimeter is 2 * (A + B).

        The goal is to find the minimal perimeter of any rectangle whose area equals N. 
        The sides of this rectangle should be only integers.

        For example, given integer N = 30, rectangles of area 30 are:
            (1, 30), with a perimeter of 62,
            (2, 15), with a perimeter of 34,
            (3, 10), with a perimeter of 26,
            (5, 6), with a perimeter of 22.
        Write a function:

            class Solution { public int solution(int N); }

        that, given an integer N, 
        returns the minimal perimeter of any rectangle whose area is exactly equal to N.

        For example, given an integer N = 30, the function should return 22, 
        as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(sqrt(N))
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int Solution(int N)
        {
            var width = 1;
            var height = 1;
            for (var i = (int)Math.Sqrt(N); i > 0; i--)
            {
                if (N % i == 0)
                {
                    width = i;
                    height = N / i;
                    break;
                }
            }
            return (width + height) * 2;
        }
    }
}
