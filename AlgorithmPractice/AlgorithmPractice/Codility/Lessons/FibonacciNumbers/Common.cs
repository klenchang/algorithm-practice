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

        public static int[] GetFibonacciListBaseOnN(int n)
        {
            if (n < 0) return new int[0];
            if (n == 0) return new int[] { 0 };
            if (n == 1) return new int[] { 0, 1 };
            var fx = new int[n + 1];
            fx[0] = 0;
            fx[1] = 1;
            for (int i = 2; i <= n; i++)
                fx[i] = fx[i - 1] + fx[i - 2];

            return fx;
        }
    }
}
