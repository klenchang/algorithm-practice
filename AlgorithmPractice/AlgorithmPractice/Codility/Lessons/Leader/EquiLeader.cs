using System.Collections.Generic;

namespace AlgorithmPractice.Codility.Lessons.Leader
{
    public class EquiLeader
    {
        #region topic
        /*
        A non-empty array A consisting of N integers is given.
        The leader of this array is the value 
        that occurs in more than half of the elements of A.
        An equi leader is an index S such that 0 ≤ S < N − 1 
        and two sequences A[0], A[1], ..., A[S] 
        and A[S + 1], A[S + 2], ..., A[N − 1] have leaders of the same value.

        For example, given array A such that:
            A[0] = 4
            A[1] = 3
            A[2] = 4
            A[3] = 4
            A[4] = 4
            A[5] = 2
        we can find two equi leaders:
        0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.
        2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.
       
        The goal is to count the number of equi leaders.
        Write a function:

            class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N integers, 
        returns the number of equi leaders.

        For example, given:
            A[0] = 4
            A[1] = 3
            A[2] = 4
            A[3] = 4
            A[4] = 4
            A[5] = 2
        the function should return 2, as explained above.

        Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].
        
        Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
         */
        #endregion

        /// <summary>
        /// time complexity: O(N)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int[] A)
        {
            if (A.Length < 2) return 0;

            var result = FindLeaderAndCount(A);
            if (result == "-1") return 0;
            var leader = int.Parse(result.Split(',')[0]);
            var leaderCount = int.Parse(result.Split(',')[1]);

            var count = 0;
            var leftLeaderCount = 0;
            for (var index = 0; index < A.Length; index++)
            {
                if (A[index] == leader)
                    leftLeaderCount++;
                if ((leftLeaderCount > (index + 1) / 2) &&
                   ((leaderCount - leftLeaderCount) > (A.Length - index - 1) / 2))
                    count++;
            }
            return count;
        }

        public static string FindLeaderAndCount(int[] A)
        {
            var stack = new Stack<int>();
            var index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (stack.Count == 0 || stack.Peek() == A[i])
                {
                    stack.Push(A[i]);
                    index = i;
                }
                else if (stack.Peek() != A[i])
                    stack.Pop();
            }
            if (stack.Count == 0) return "-1";
            var candidate = stack.Peek();
            var count = 0;
            foreach (var n in A)
                if (candidate == n) count++;

            return count > A.Length / 2 ? A[index] + "," + count : "-1";
        }
    }
}
