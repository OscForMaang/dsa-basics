namespace Queue.Implementation
{
    internal class Node
    {
        public Node link;
        public int key;
        public Node(int key)
        {
            link = null;
            this.key = key;
        }
    }
}
