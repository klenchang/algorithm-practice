using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays
{
    public class ArrayDynamic
    {
        #region topic
        /*
        Declare a 2-dimensional array, , of  empty arrays. All arrays are zero indexed.
        Declare an integer, , and initialize it to .

        There are  types of queries, given as an array of strings for you to parse:

        Query: 1 x y
        Let idx = ((x xor lastAnswer) % n).
        Append the integer y to arr[idx].
        Query: 2 x y
        Let idx = ((x xor lastAnswer) % n).
        Assign the value arr[idx][y % size (arr[idx])] to lastAnswer.
        Store the new value of lastAnswer to an answers array. 

        Function Description
        Complete the dynamicArray function below.
            dynamicArray has the following parameters:
            - int n: the number of empty arrays to initialize in arr
            - string queries[q]: query strings that contain 3 space-separated integers
        Returns
            int[]: the results of each type 2 query in the order they are presented
        Input Format
            The first line contains two space-separated integers, n, the size of arr to create, 
            and q, the number of queries, respectively.
            Each of the q subsequent lines contains a query string, queries[i].
        Constraints
            1 <= n,q <= Pow(10, 5)
            0 <= x,y <= Pow(10, 9)
            It is guaranteed that query type 2 will never query an empty array or index.

        Sample Input
            2 5
            1 0 5
            1 1 7
            1 0 3
            2 1 0
            2 1 1
        Sample Output
            7
            3
         */
        #endregion

        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var temp = new List<List<int>>();
            for (var i = 1; i <= n; i++)
                temp.Add(new List<int>());

            var lastAnswer = 0;
            var result = new List<int>();
            foreach(var q in queries)
            {
                var idx = (q[1] ^ lastAnswer) % n;
                if (q[0] == 1)
                    temp[idx].Add(q[2]);
                else
                {
                    lastAnswer = temp[idx][q[2] % temp[idx].Count];
                    result.Add(lastAnswer);
                }
            }
            return result;
        }
    }
}
