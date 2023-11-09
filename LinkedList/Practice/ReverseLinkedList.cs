using LinkedList.SinglyLinkedList;

namespace LinkedList.Practice
{
    internal class ReverseLinkedList
    {
        /// <summary>
        /// Iterative way to reverse a linklist
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node Reverse(Node head)
        {
            Node current = head;
            Node previous = null;

            while(current != null)
            {
                Node next = current.link;
                current.link = previous;
                previous = current;
                current = next;
            }

            return previous;
        }


        public Node ReverseRec(Node head)
        {
            if (head == null || head.link == null)
                return head;

            Node newHead = Reverse(head.link);
            Node newNext = head.link;
            newNext.link = head ;
            head.link = null;

            return newHead;
        }
    }
}
