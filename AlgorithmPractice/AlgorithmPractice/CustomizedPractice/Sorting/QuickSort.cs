namespace AlgorithmPractice.CustomizedPractice.Sorting
{
    public class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            Sort(ref array, 0, array.Length - 1);
            return array;
        }
        private static void Sort(ref int[] array, int left, int right)
        {
            if (left < 0 || right >= array.Length || (right - left) <= 0)
                return;

            var start = left;
            var end = right;
            var standard = array[left];
            while (start != end)
            {
                while (array[end] >= standard && start < end)
                    end -= 1;
                while (array[start] <= standard && start < end)
                    start += 1;
                if (start < end)
                {
                    var temp = array[end];
                    array[end] = array[start];
                    array[start] = temp;
                }
            }
            array[left] = array[start];
            array[start] = standard;

            Sort(ref array, left, start - 1);
            Sort(ref array, start + 1, right);
        }
    }
}
