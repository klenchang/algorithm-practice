namespace AlgorithmPractice.Hackerrank.Interview.Arrays
{
    public class MinimumSwaps
    {
        #region topic
        /*
        You are given an unordered array consisting of consecutive integers  
        [1, 2, 3, ..., n] without any duplicates.

        Example
        arr = [7,1,3,2,4,5,6]
        It took 5 swaps to sort the array.

        Constraints
        1 <= n <= 10 ** 5
        1 <= arr[i] <= n
         */
        #endregion

        // first to record current position for every numbers
        // then check every element in arr from 0 to arr.Length - 1
        // if arr[i] is not equal i + 1, you need to do swap with number i + 1
        // for example, 7132456
        // when you check first element, it's 7, then you need to swap with 1
        // after swapping, you will get 1732456, then check second number again
        // it's 7 too. so this time swap 7 and 2 and so on.
        public static int MinimumSwap(int[] arr)
        {
            var positions = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                positions[arr[i]] = i;

            var swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - 1 != i)
                {
                    // if i = 0, currentPosition = current index of number 1
                    var currentPosition = positions[i + 1];
                    // swap value
                    arr[currentPosition] = arr[i];
                    // swap position
                    positions[arr[i]] = currentPosition;
                    arr[i] = i + 1;
                    positions[i + 1] = i;
                    swap++;
                }
            }
            return swap;
        }
    }
}
