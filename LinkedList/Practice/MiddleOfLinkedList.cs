using LinkedList.SinglyLinkedList   ;

namespace LinkedList.Practice
{
    internal class MiddleOfLinkedList
    {
        public Node FindMiddle(Node node)
        {
            Node fast = node;
            Node slow = node;

            while (fast != null && fast.link != null)
            {
                fast = fast.link.link; 
                slow = slow.link;
            }

            return slow;
        }
    }
}
