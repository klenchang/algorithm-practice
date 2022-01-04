using System.Collections.Generic;

namespace AlgorithmPractice.CustomizedPractice.DynamicProgram

{
    public class NSumToFindTarget
    {
        #region
        /*
         give a array which elements are positive number.
         give a number as target to find sets of numbers that add up to 16.
         for example, 
            array = [2, 4, 6, 10]
            target = 16
            result = 2
            explain, [2, 4, 10], [6, 10]

         logic => answer could be think as sets of numbers that include X + sets of numbers that exclude X

         reference: https://www.youtube.com/watch?v=nqlNzOcnCfs
         */
        #endregion

        public class SolutionWithRecursive
        {
            public static int Count(int[] array, int target)
            {
                return Recursive(array, target, array.Length - 1);
            }
            public static int Recursive(int[] array, int target, int index)
            {
                if (target == 0)
                    return 1;
                else if (target < 0 || index < 0)
                    return 0;
                else if (target < array[index])
                    return Recursive(array, target, index - 1);
                else
                    return Recursive(array, target - array[index], index - 1) + 
                           Recursive(array, target, index - 1);
            }
        }

        public class SolutionWithRecursiveAndMemoized
        {
            public static int CountWithDP(int[] array, int target)
            {
                Dictionary<string, int> memory = new Dictionary<string, int>();
                return DP(array, target, array.Length - 1, memory);
            }
            public static int DP(int[] array, int target, int index, Dictionary<string, int> memory)
            {
                var key = $"{target}:{index}";
                var returnValue = -1;
                if (memory.ContainsKey(key))
                    return memory[key];
                if (target == 0)
                    return 1;
                else if (target < 0 || index < 0)
                    return 0;
                else if (target < array[index])
                    returnValue = DP(array, target, index - 1, memory);
                else
                    returnValue = DP(array, target - array[index], index - 1, memory) + 
                                  DP(array, target, index - 1, memory);

                memory[key] = returnValue;
                return returnValue;
            }
        }
    }
}
