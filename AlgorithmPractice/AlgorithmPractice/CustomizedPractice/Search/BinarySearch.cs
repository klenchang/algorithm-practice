namespace AlgorithmPractice.CustomizedPractice.Search
{
    public class BinarySearch
    {
        public static int Search(int[] sortedArray, int target)
        {
            var startIndex = 0;
            var endIndex = sortedArray.Length - 1;
            while (startIndex <= endIndex)
            {
                var mid = (startIndex + endIndex) / 2;
                if (sortedArray[mid] == target)
                    return mid;
                else if (sortedArray[mid] > target)
                    endIndex = mid - 1;
                else
                    startIndex = mid + 1;
            }
            return -1;
        }
    }
}
