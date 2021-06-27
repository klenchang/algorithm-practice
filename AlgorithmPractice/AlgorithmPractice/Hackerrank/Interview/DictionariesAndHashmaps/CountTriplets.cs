using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps
{
    public class CountTriplets
    {
        #region topic
        /*
        You are given an array and you need to find number of tripets of indices (i,j,k)
        such that the elements at those indices are in geometric progression for a given 
        common ratio r and i < j < k.
        
        Example.
        arr = [1,4,16,64], r = 4 => [1,4,16], [4,16,64] => return 2.
        arr = [1,2,2,4], r = 2 => [1,2,4] * 2 => return 2
        arr = [1,3,9,9,27,81], r = 3 => [1,3,9] * 2, [3,9,27] * 2, [9,27,81] * 2 => 6
         */
        #endregion

        public static long Solution(List<long> arr, long r)
        {
            var dictRight = new Dictionary<long, long>();
            foreach (var n in arr)
                InsertNumberToDictionary(dictRight, n);

            var dictLeft = new Dictionary<long, long>();
            long result = 0;
            foreach (var n in arr)
            {
                //important! for r = 1, must need to minus 1 for middle (middle of triple) element
                dictRight[n]--; 
                if (n % r == 0)
                {
                    if (dictLeft.ContainsKey(n / r) && dictRight.ContainsKey(n * r))
                        result += dictLeft[n / r] * dictRight[n * r];
                }
                InsertNumberToDictionary(dictLeft, n);
            }

            return result;
        }
        public static void InsertNumberToDictionary(Dictionary<long, long> dict, long number)
        {
            if (dict.ContainsKey(number))
                dict[number]++;
            else
                dict.Add(number, 1);
        }
    }
}
