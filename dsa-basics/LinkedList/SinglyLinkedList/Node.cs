namespace LinkedList.SinglyLinkedList
{
    /// <summary>
    /// Node for singlyLikedList 
    /// </summary>
    internal class Node
    {
        public int key;
        public Node link;
        public Node(int key)
        {
            this.key = key;
            link = null;
        }
    }
}