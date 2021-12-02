using System;

namespace AlgorithmPractice.CustomizedPractice.Sorting
{
    public class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        private static int[] Sort(int[] array, int left, int right)
        {
            var mid = (left + right) / 2;
            if (left < right)
            {
                Sort(array, left, mid);
                Sort(array, mid + 1, right);
            }
            var startIndex = left;
            var endIndex = mid + 1;
            var temp = new int[right - left + 1];
            var tempIndex = 0;
            while (startIndex <= mid && endIndex <= right)
            {
                if (array[startIndex] <= array[endIndex])
                    temp[tempIndex++] = array[startIndex++];
                else
                    temp[tempIndex++] = array[endIndex++];
            }
            if (startIndex != mid + 1)
                while (startIndex <= mid)
                    temp[tempIndex++] = array[startIndex++];

            if (endIndex != right + 1)
                while (endIndex <= right)
                    temp[tempIndex++] = array[endIndex++];

            Array.Copy(temp, 0, array, left, right + 1 - left);

            return temp;
        }
    }
}
