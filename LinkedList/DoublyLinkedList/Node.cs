namespace LinkedList.DoublyLinkedList
{

    /// <summary>
    /// Node for DoublyLinkedList
    /// </summary>
    internal class Node
    {
        public int key;
        public Node next;
        public Node prev;
        public Node(int key)
        {
            this.key = key;
            next = null;
            prev = null;
        }
    }
}