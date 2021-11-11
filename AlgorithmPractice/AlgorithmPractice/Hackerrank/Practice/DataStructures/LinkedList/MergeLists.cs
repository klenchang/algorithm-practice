namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.LinkedList
{
    public class MergeLists
    {
        public static SinglyLinkedListNode Merge(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode result;
            if (head1.data <= head2.data)
            {
                result = head1;
                head1 = head1.next;
            }
            else
            {
                result = head2;
                head2 = head2.next;
            }
            SinglyLinkedListNode temp = result;
            while (head1 != null && head2 != null)
            {
                if (head1.data <= head2.data)
                {
                    temp.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    temp.next = head2;
                    head2 = head2.next;
                }
                temp = temp.next;
            }
            if (head1 != null) temp.next = head1;
            if (head2 != null) temp.next = head2;

            return result;
        }
    }
}
