namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class InsertNodeAtPosition
    {
        public static SinglyLinkedListNode InsertNode(SinglyLinkedListNode llist, int data, int position)
        {
            var currentIndex = 0;
            SinglyLinkedListNode head = llist;
            while (currentIndex < position && head != null)
            {
                if (currentIndex == position - 1)
                {
                    SinglyLinkedListNode insertedNode = new SinglyLinkedListNode(data) { next = head.next };
                    head.next = insertedNode;

                    return llist;
                }
                else
                {
                    head = head.next;
                    currentIndex++;
                }
            }
            return null;
        }
    }
}
