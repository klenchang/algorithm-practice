namespace AlgorithmPractice.Hackerrank.Interview.DynamicProgram
{
    public class Abbreviation
    {
        #region topic
        /*
        You can perform the following operations on the string, a:
            Capitalize zero or more of a's lowercase letters.
            Delete all of the remaining lowercase letters in a. 

        Given two strings, a and b, determine if it's possible to make a equal to b as described. 
        If so, print YES on a new line. Otherwise, print NO.

        Example.
        a = AbcDE, b = ABDE => YES
        a = AbcDE, b = AFDE => NO
        a = AbBcDE, b = ABCDE => YES

        Constraints
        1 <= q <= 10
        1 <= a.Length, b.Length <= 1000
        a consists with [a-zA-Z]
        b consists with [A-Z]
         */
        #endregion

        /// <summary>
        /// refer to geraldlow from https://www.hackerrank.com/challenges/abbr/forum/comments/484833
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string Solution(string a, string b)
        {
            var isValid = new bool[a.Length + 1, b.Length + 1];
            // initializing the first raw to all false; ie. if b is
            // not empty, isValid will always be false
            isValid[0, 0] = true;
            // array initialization - if a is non-empty but b is empty,
            // then isValid == true iff remaining(a) != contain uppercase
            bool containsUppercase = false;
            for (int k = 1; k <= a.Length; k++)
            {
                int i = k - 1;
                // if the pointer at string a is uppercase
                if (a[i] <= 'Z' && a[i] >= 'A' || containsUppercase)
                {
                    containsUppercase = true;
                    isValid[k, 0] = false;
                }
                else isValid[k, 0] = true;
            }
            // tabulation from start of string
            for (int k = 1; k <= a.Length; k++)
            {
                for (int l = 1; l <= b.Length; l++)
                {
                    int i = k - 1; int j = l - 1;
                    // when the characters are equal, set = previous character bool.
                    if (a[i] == b[j])
                    {
                        isValid[k, l] = isValid[k - 1, l - 1];
                        continue;
                    }
                    // elif uppercase a == b, set = prev character bool. or just eat a.
                    else if ((int)a[i] - 32 == (int)b[j])
                    {
                        isValid[k, l] = isValid[k - 1, l - 1] || isValid[k - 1, l];
                        continue;
                    }
                    // elif a is uppercase and no more b, or uppercase a is not b, then false
                    else if (a[i] <= 90 && a[i] >= 65)
                    {
                        isValid[k, l] = false;
                        continue;
                    }
                    //else just eat a
                    else
                    {
                        isValid[k, l] = isValid[k - 1, l];
                        continue;
                    }
                }
            }
            return isValid[a.Length, b.Length] ? "YES" : "NO";
        }
    }
}
