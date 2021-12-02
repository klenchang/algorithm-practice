namespace AlgorithmPractice.LeetCode.Problems
{
    public class FindJudge
    {
        /*
        In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.

        If the town judge exists, then:
        - The town judge trusts nobody.
        - Everybody (except for the town judge) trusts the town judge.
        - There is exactly one person that satisfies properties 1 and 2.
        You are given an array trust where trust[i] = [ai, bi] representing that the person labeled 
        ai trusts the person labeled bi.

        Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.
        
        Constraints:
            1 <= n <= 1000
            0 <= trust.length <= 104
            trust[i].length == 2
            All the pairs of trust are unique.
            ai != bi
            1 <= ai, bi <= n

        copy@https://leetcode.com/problems/find-the-town-judge/
         */

        public static int Find(int n, int[][] trust)
        {
            if (n == 1) return n;
            var count = new int[n + 1]; // count of be trusted times
            var isTrustOthers = new bool[n + 1];    // whether trust others
            foreach (var condition in trust)
            {
                var firstPerson = condition[0];
                var secondPerson = condition[1];
                isTrustOthers[firstPerson] = true;
                count[secondPerson]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                if (!isTrustOthers[i] && count[i] == n - 1)
                    return i;
            }

            return -1;
        }
    }
}
