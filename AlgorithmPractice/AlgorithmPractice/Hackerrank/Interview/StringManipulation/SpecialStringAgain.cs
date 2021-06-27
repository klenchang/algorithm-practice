namespace AlgorithmPractice.Hackerrank.Interview.StringManipulation
{
    public class SpecialStringAgain
    {
        #region topic
        /*
        A string is said to be a special string if either of two conditions is met:
            All of the characters are the same, e.g. aaa.
            All characters except the middle one are the same, e.g. aadaa.
        A special substring is any substring of a string which meets one of those criteria. 
        Given a string, determine how many special substrings can be formed from it. 

        Example.
        s = mnonopoo => { m, n, o, n, o, p, o, o, non, ono, opo, oo } => 12
        s = aaaa => { a, a, a, a, aa, aa, aa, aaa, aaa, aaaa} => 10

        Constraints
        1 <= n <= 10 ** 6

        Write a function to return maximun of special substring number
         */
        #endregion

        public static long SubstrCount(int n, string s)
        {
            var cnt = 1;
            var frequency = 1;
            // count consecutive characters which match rule 1
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    frequency++;
                    cnt += frequency;
                }
                else
                {
                    frequency = 1;
                    cnt += frequency;
                }
            }
            // count mirror substring which match rule 2
            // notice! abcba is not allow. but aabaa is allow
            for (int i = 1; i < s.Length - 1; i++)
            {
                var distance = 1;
                while (i - distance >= 0 && i + distance < s.Length)
                {
                    if (s[i - distance] == s[i + distance] && s[i] != s[i - distance])
                    {
                        if (distance == 1 || s[i - distance] == s[i - distance + 1])
                            cnt++;
                        else
                            break;
                    }
                    else
                        break;
                    distance++;
                }
            }

            return cnt;
        }

        //solution from shesanmigz on 
        //https://www.hackerrank.com/challenges/special-palindrome-again/forum/comments/475070?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
        public static long SubstrCount2(int n, string s)
        {
            // initialize counter to n because each character is a
            // palindromic string
            int counter = n;

            // to count consecutive characters that are the same
            int consec = 1;

            // the middle index of a 3-character symmetry,
            // assigned only once detected
            int midIndex = -1;

            // compare with previous character so start with i=1
            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    // Condition 1: All of the characters are the same
                    // For n consecutive characters that are the same,
                    // we have this formula:
                    // Number of palindromic strings =
                    //     (n-1) + (n-2) + ... + (n-(n-1))
                    counter += consec;
                    consec++;

                    // Condition 2: All characters except the middle one
                    // are the same
                    if (midIndex > 0)
                    {
                        // check for symmetry on both sides
                        // of the midIndex
                        if ((midIndex - consec) >= 0 && s[midIndex - consec] == s[i])
                        {
                            counter++;
                        }
                        else
                        {
                            // no more possibility of palindromic string
                            // with this midIndex
                            midIndex = -1;
                        }
                    }
                }
                else
                {
                    // reset consecutive chars counter to 1
                    consec = 1;

                    // check for a 3-character symmetry
                    if (((i - 2) >= 0) && s[i - 2] == s[i])
                    {
                        counter++; // 3-char symmetry is detected

                        // to check if the next characters are the same
                        // and symmetrical along the midIndex
                        midIndex = i - 1;
                    }
                    else
                    {
                        midIndex = -1;
                    }
                }
            }
            return counter;
        }
    }
}
