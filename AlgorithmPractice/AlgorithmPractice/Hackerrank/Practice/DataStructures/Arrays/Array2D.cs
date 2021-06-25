using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Arrays
{
    public class Array2D
    {
        #region topic
        /*
        Give a hourglass.
        -9 -9 -9  1 1 1 
         0 -9  0  4 3 2
        -9 -9 -9  1 2 3
         0  0  8  6 6 0
         0  0  0 -2 0 0
         0  0  1  2 4 0

         Caculate sum as 
         -63, -34, -9, 12, 
         -10,   0, 28, 23, 
         -27, -11, -2, 10, 
           9,  17, 25, 18

         hourglass is 
         a b c
           d
         e f g

         return largest (maximum) hourglass sum
        
        Constraints: 
        -9 <= arr[i][j] <= 9
        0 <= i,j <= 5
        */
        #endregion

        public static int HourglassSum(List<List<int>> arr)
        {
            var array2D = arr.ToArray();
            var max = int.MinValue;
            for (var y = 0; y < array2D.Length - 2; y++)
            {
                for (var x = 0; x < array2D[y].Count - 2; x++)
                {
                    var sum = array2D[y][x] + array2D[y][x + 1] + array2D[y][x + 2];
                    sum += array2D[y + 1][x + 1];
                    sum += array2D[y + 2][x] + array2D[y + 2][x + 1] + array2D[y + 2][x + 2];
                    if (sum > max)
                        max = sum;
                }
            }
            return max;
        }
    }
}
