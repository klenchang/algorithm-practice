namespace AlgorithmPractice.CustomizedPractice.Sorting
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var indexOfMin = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[i])
                        indexOfMin = j;
            
                if (indexOfMin != i)
                {
                    var temp = array[indexOfMin];
                    array[indexOfMin] = array[i];
                    array[i] = temp;
                }
            }

            return array;
        }
    }
}
