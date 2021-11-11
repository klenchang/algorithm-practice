namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class RevertLinkedList
    {
        public static SinglyLinkedListNode Revert(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode head = llist;
            SinglyLinkedListNode prev = null;
            while (head != null)
            {
                SinglyLinkedListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }
}
