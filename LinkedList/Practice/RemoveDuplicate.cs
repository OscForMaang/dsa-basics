using LinkedList.SinglyLinkedList;

namespace LinkedList.Practice
{
    internal class RemoveDuplicate
    {
        /// <summary>
        /// Remove duplicate element from the sorted linked list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node RemoveDuplicateNode(Node head)
        {
            Node curr = head;

            while (curr.link != null)
            {
                if(curr.key == curr.link.key)
                {
                    curr.link = curr.link.link;
                }
                else
                {
                    curr = curr.link;
                }
            }
            return curr;
        }
    }
}
