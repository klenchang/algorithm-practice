using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays
{
    public class Arrays
    {
        #region topic
        /*
            Reverse array
        */
        #endregion

        public static List<int> ReverseArray(List<int> a)
        {
            var result = new List<int>();
            for (var i = a.Count - 1; i >= 0; i--)
            {
                result.Add(a[i]);
            }
            return result;
        }
    }
}
