using System;

namespace AlgorithmPractice.Codility.Lessons.FutureTraining
{
    public class StrSymmetryPoint
    {
        #region topic
        /*
        Write a function:

            class Solution { public int solution(String S); }

        that, given a string S, returns the index (counting from 0) of a character such that 
        the part of the string to the left of that character is a reversal of the part of the 
        string to its right. The function should return −1 if no such index exists.

        Note: reversing an empty string (i.e. a string whose length is zero) gives an empty string.

        For example, given a string:

            "racecar"

        the function should return 3, because the substring to the left of the character "e" 
        at index 3 is "rac", and the one to the right is "car".

        Given a string:

            "x"

        the function should return 0, because both substrings are empty.

        Write an efficient algorithm for the following assumptions:
            the length of S is within the range [0..2,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        ///  time complexity: O(length(S))
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int Solution(String S)
        {
            if (S.Length % 2 == 0) return -1;
            if (S.Length == 1) return 0;
            var midIndex = S.Length / 2;
            for (var i = 1; i <= midIndex; i++)
            {
                if (S[midIndex - i] != S[midIndex + i])
                    return -1;
            }
            return midIndex;
        }
    }
}
