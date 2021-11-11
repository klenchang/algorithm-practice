namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class InsertNodeAtTail
    {
        public static SinglyLinkedListNode InsertNode(SinglyLinkedListNode head, int data)
        {
            if (head == null) return new SinglyLinkedListNode(data);
            var tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = new SinglyLinkedListNode(data);

            return head;
        }
    }
}
