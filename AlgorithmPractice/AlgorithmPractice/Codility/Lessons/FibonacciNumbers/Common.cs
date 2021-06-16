using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.FibonacciNumbers
{
    public class Common
    {
        public static int[] GetFibonacciList(int maxValue)
        {
            var fx = new List<int>();
            var fn = -1;
            for (int i = 0; fn <= maxValue; i++)
            {
                if (i == 0) fn = 0;
                else if (i == 1) fn = 1;
                else fn = fx[i - 2] + fx[i - 1];
                if (fn <= maxValue)
                    fx.Add(fn);
            }

            return fx.ToArray();
        }
    }
}
