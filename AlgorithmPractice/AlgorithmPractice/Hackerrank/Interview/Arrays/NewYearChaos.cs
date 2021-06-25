using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Interview.Arrays
{
    public class NewYearChaos
    {
        #region topic
        /*
        It is New Year's Day and people are in line for the Wonderland rollercoaster ride. 
        Each person wears a sticker indicating their initial position in the queue from 1 to n. 
        Any person can bribe the person directly in front of them to swap positions, 
        but they still wear their original sticker. 
        One person can bribe at most two others.

        Determine the minimum number of bribes that took place to get to a given queue order. 
        Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic. 

        Example
        q = [1,2,3,5,4,6,7,8]
        only 1 bribe is required. person 5 swap person 4.

        q = [4,1,2,3]
        person 4 had to bribe 3 people to get to the current position. Print Too chaotic.
         */
        #endregion

        public static void MinimumBribes(List<int> q)
        {
            var totalSwap = 0;
            for (int i = 0; i < q.Count; i++)
            {
                var currentSwap = (q[i] - 1) - i;
                if (currentSwap > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                // q[i] - 1 is original index, if a number (called x) swap it twice,
                // then position of x will be (q[i] - 1) - 1
                var start = Math.Max(0, q[i] - 1 - 1);
                for (int y = start; y < i; y++)
                {
                    if (q[y] > q[i])
                        totalSwap++;
                }
            }
            Console.WriteLine(totalSwap);
        }
    }
}
