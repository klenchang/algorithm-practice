using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps
{
    public class FrequencyQueries
    {
        #region topic
        /*
        You are given q queries. Each query is of the form two integers described below: 
        1 - x : Insert x in your data structure.
        2 - y : Delete one occurence of y from your data structure, if present.
        3 - z : Check if any integer is present whose frequency is exactly z. If yes, print 1 else 0.
        
        Example.
        queries = [(1,1), (2,2), (3,2), (1,1), (1,1), (2,1), (3,2)]
        Operation   Array   Output
        (1,1)       [1]
        (2,2)       [1]
        (3,2)                   0
        (1,1)       [1,1]
        (1,1)       [1,1,1]
        (2,1)       [1,1]
        (3,2)                   1
        return an array with the output: [0,1]

        Constraints
        1 <= q <= 10 ** 5
        1 <= x,y,z <= 10 ** 9
        queries[i][0] belong to {1,2,3}
        1 <= queries[i][1] <= 10 ** 9
         */
        #endregion

        public static List<int> Solution(List<List<int>> queries)
        {
            var dict = new Dictionary<int, long>();
            var res = new List<int>();
            var count = new Dictionary<long, int>();
            foreach (var q in queries)
            {
                var action = q[0];
                int value = q[1];
                if (action == 1)
                {
                    if (dict.ContainsKey(value))
                    {
                        count[dict[value]]--;
                        dict[value]++;
                        AddOrInsertToDictionary(count, dict[value]);
                    }
                    else
                    { 
                        dict.Add(value, 1);
                        AddOrInsertToDictionary(count, 1);
                    }
                }
                else if (action == 2)
                {
                    if (dict.ContainsKey(value) && dict[value] > 0)
                    {
                        count[dict[value]]--;
                        dict[value]--;
                        if (dict[value] != 0)
                            AddOrInsertToDictionary(count, dict[value]);
                    }
                }
                else
                {
                    res.Add(count.ContainsKey(value) && count[value] > 0 ? 1 : 0);
                }
            }
            return res;
        }
        public static void AddOrInsertToDictionary(Dictionary<long, int> dict, long key)
        {
            if (dict.ContainsKey(key))
                dict[key]++;
            else
                dict.Add(key, 1);
        }
    }
}
