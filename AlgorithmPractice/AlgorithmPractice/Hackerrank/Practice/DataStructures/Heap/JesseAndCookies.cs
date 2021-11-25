using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Heap
{
    public class JesseAndCookies
    {
        /*
         Jesse loves cookies and wants the sweetness of some cookies to be greater than value k. 
         To do this, two cookies with the least sweetness are repeatedly mixed. 
         This creates a special combined cookie with:
            sweetness = 1 * Least sweet cookie + 2 * 2nd least sweet cookie).

         This occurs until all the cookies have a sweetness >= k.
         Given the sweetness of a number of cookies, determine the minimum number of operations
         required. If it is not possible, return -1.
         */

        public static int Cookies(int k, List<int> A)
        {
            A.Sort();
            Queue<int> queue1 = new Queue<int>();
            // use queue2 to store combined result, so that we don't need to sort again.
            Queue<int> queue2 = new Queue<int>();
            // if isPossible is true, means there are sweetness of cookies over k
            bool isPossible = false; 
            foreach (var i in A)
            {
                if (i < k)
                    queue1.Enqueue(i);
                else
                {
                    isPossible = true;
                    break;
                }
            }
            var operations = 0;
            while ((queue1.Count + queue2.Count) > 1)
            {
                int first = ChooseOne(queue1, queue2);
                int second = ChooseOne(queue1, queue2);
                int sweetness = first + 2 * second;
                if (sweetness < k)
                    queue2.Enqueue(sweetness);
                else
                    isPossible = true;

                operations++;
            }
            if ((queue1.Count + queue2.Count) != 0)
                operations++;

            return isPossible ? operations : -1;
        }
        public static int ChooseOne(Queue<int> queue1, Queue<int> queue2)
        {
            int result;
            if (queue1.Count == 0) result = queue2.Dequeue();
            else if (queue2.Count == 0) result = queue1.Dequeue();
            else
            {
                result = queue1.Peek() < queue2.Peek() ? queue1.Dequeue() : queue2.Dequeue();
            }
            return result;
        }
    }
}
