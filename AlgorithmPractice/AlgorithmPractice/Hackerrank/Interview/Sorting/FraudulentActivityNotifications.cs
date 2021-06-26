using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Interview.Sorting
{
    public class FraudulentActivityNotifications
    {
        #region topic
        /*
        The HankerLand National Bank has a policy to send fraudulent activity notifications.
        Give a array as client's transaction amount everyday.
        If transaction amount of today >= double median of previous "d" days transaction, bank will send notification.
        It means bank will send it if amount >= 2 * median.

        For example,
        expenditures = [10,20,30,40,50], d = 3
        it will send one notification, because only checking of 4th day will be passed.
        [10,20,30] => median is 20 => 40 >= 2 * 20
        so return 1.

        Constraints
        1 <= n <= 2 * 10 ** 5
        1 <= d <= n
        0 <= expenditures[i] <= 200
         */
        #endregion

        /// <summary>
        /// Too slow
        /// </summary>
        /// <param name="expenditure"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Solution1(List<int> expenditure, int d)
        {
            var length = expenditure.Count;
            if (length < d + 1 || length < 2)
                return 0;

            var temp = new List<int>();
            for (int i = 0; i < d; i++)
                temp.Add(expenditure[i]);

            var notification = 0;
            for (int i = d; i < length; i++)
            {
                var mid = -1M;
                var sorted = temp.OrderBy(n => n).ToList();
                if (temp.Count % 2 == 1)
                    mid = sorted[temp.Count / 2];
                else
                    mid = ((decimal)sorted[temp.Count / 2] + (decimal)sorted[temp.Count / 2 - 1]) / 2;

                if (expenditure[i] >= 2 * mid)
                    notification++;
                temp.RemoveAt(0);
                temp.Add(expenditure[i]);
            }
            return notification;
        }

        public static int Solution2(List<int> expenditure, int d)
        {
            var length = expenditure.Count;
            if (length < d + 1 || length < 2)
                return 0;

            var counts = new int[201];
            for (int i = 0; i < d; i++)
                counts[expenditure[i]]++;

            var notification = 0;
            for (int i = d; i < length; i++)
            {
                var mid = GetMid(counts, d);

                if (expenditure[i] >= 2 * mid)
                    notification++;

                counts[expenditure[i - d]]--;
                counts[expenditure[i]]++;
            }
            return notification;
        }

        public static decimal GetMid(int[] counts, int d)
        {
            var cnt = 0;
            var firstEvenMidNumber = -1m;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    cnt += counts[i];
                    if (d % 2 == 1)
                    {
                        if (cnt > d / 2)
                            return i;
                    }
                    else
                    {
                        if (cnt > d / 2)
                        {
                            if (firstEvenMidNumber != -1)
                                return (firstEvenMidNumber + i) / 2;
                            else
                                return i;
                        }
                        else if (cnt == d / 2)
                        {
                            firstEvenMidNumber = i;
                        }
                    }
                }
            }
            throw new Exception("There is no median");
        }
    }
}
