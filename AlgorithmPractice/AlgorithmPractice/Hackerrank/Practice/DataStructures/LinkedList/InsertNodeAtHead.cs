namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class InsertNodeAtHead
    {
        public static SinglyLinkedListNode InsertNode(SinglyLinkedListNode head, int data)
        {
            return new SinglyLinkedListNode(data) { next = head };
        }
    }
}
