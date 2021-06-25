using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays
{
    public class LeftRotation
    {
        #region topic
        /*
        A left rotation operation on an array of size n shifts each of the array's elements 1 unit to the left. 
        Given an integer, d, rotate the array that many steps left and return the result.
        
        Example
        d = 2
        arr = [1,2,3,4,5]
        after 2 rotations, arr' = [3,4,5,1,2]

        Constraints
        1 <= n <= Power(10, 5)
        1 <= d <= n
        1 <= a[i] <= Power(10, 6)

        write a function to do left rotation.
         */
        #endregion

        public static List<int> RotateLeft(int d, List<int> arr)
        {
            var rotationTimes = d % arr.Count;
            if (rotationTimes == 0)
                return arr;
            else
                return arr.GetRange(rotationTimes, arr.Count - rotationTimes)
                          .Concat(arr.GetRange(0, rotationTimes))
                          .ToList();
        }
    }
}
