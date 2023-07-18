namespace LinkedList.CircularLinkedList
{
    internal class CircularLinkedList
    {
        private Node head;
        private Node tail;
        public CircularLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        /// <summary>
        /// Insert an element in circular linked list
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }

            tail.link = newNode;
            newNode.link = head;
            tail = newNode; 
        }

        /// <summary>
        /// Display elements of circular linked list
        /// </summary>
        public void Display()
        {
            Node curr = head;

            if(head != null)
            {
                do
                {
                    Console.WriteLine(curr.key + " -> ");
                    curr = curr.link;

                }while (curr != head);
            }
        }

        /// <summary>
        /// Delete a value from circular linked list
        /// </summary>
        /// <param name="value"></param>
        public void Delete(int value)
        {
            Node curr = head;

            if(curr == null)
            {
                Console.WriteLine("List is empty, Nothing to delete");
                return;
            }

            // value to be deleted is at head node
            if(curr.key == value)
            {
                head = head.link;
                tail.link = head;
                return;
            }

            do
            {
                Node p = curr.link;

                if(p.key == value)
                {
                    curr.link = p.link;
                    break;
                }

                curr = curr.link;
            }while(curr != head);
        }

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
}
