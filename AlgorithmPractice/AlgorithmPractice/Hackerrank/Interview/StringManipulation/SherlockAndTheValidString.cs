using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation
{
    public class SherlockAndTheValidString
    {
        #region topic
        /*
        Sherlock considers a string to be valid if all characters of 
        the string appear the same number of times. 
        It is also valid if he can remove just 1 character at 1 index in the string, 
        and the remaining characters will occur the same number of times. 
        Given a string s, determine if it is valid. If so, return YES, otherwise return NO. 

        Example.
        s = abc => valid because every characters only 1
        s = abcc => valid because remove c at index 2, all characters will only 1
        s = abccc => invalid, even remove one c, c still have 2.

        Constraints
        1 <= |s| <= 10 ** 5
        s[i] belong to [a-z]
         */
        #endregion

        public static string IsValid(string s)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;

            var showTimes = new SortedDictionary<int, int>();
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    if (!showTimes.ContainsKey(counts[i]))
                        showTimes.Add(counts[i], 1);
                    else
                        showTimes[counts[i]]++;

                    if (showTimes.Count > 2)
                        return "NO";
                }
            }
            if (showTimes.Count == 1)
                return "YES";

            var first = showTimes.FirstOrDefault();
            var second = showTimes.LastOrDefault();
            if (first.Key == 1 && first.Value == 1)
                return "YES";
            if (second.Key - first.Key == 1 && second.Value == 1)
                return "YES";

            return "NO";
        }
    }
}
