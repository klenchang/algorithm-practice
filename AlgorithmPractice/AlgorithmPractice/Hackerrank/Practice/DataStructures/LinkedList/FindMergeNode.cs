namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class FindMergeNode
    {
        /* sample
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 2, 3 };
            var llist1 = Insert(array1);
            var array2 = new[] { 4, 5 };
            var llist2 = Insert(array2);
            var array3 = new[] { 6, 7, 8 };
            var llist3 = Insert(array3);

            llist1 = Append(llist1, llist3);
            llist2 = Append(llist2, llist3);

            var result = FindMergeNode.Find(llist1, llist2);

            Console.WriteLine(result);
        }
        static SinglyLinkedListNode Append(SinglyLinkedListNode llist, SinglyLinkedListNode llist2)
        {
            var head = llist;
            while (head.next != null)
                head = head.next;
            head.next = llist2;
            return llist;
        }
        static SinglyLinkedListNode Insert(int[] datas)
        {
            SinglyLinkedListNode result = null;
            foreach (var d in datas)
            {
                result = InsertNodeAtTail.InsertNode(result, d);
            }
            return result;
        }
        */

        public static int Find(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
        {
            SinglyLinkedListNode currentA = headA;
            SinglyLinkedListNode currentB = headB;

            while (currentA != currentB)
            {
                if (currentA.next == null)
                    currentA = headB;
                else
                    currentA = currentA.next;
             
                if (currentB.next == null)
                    currentB = headA;
                else
                    currentB = currentB.next;
            }
            return currentB.data;
        }
    }
}
