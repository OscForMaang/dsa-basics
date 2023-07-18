namespace LinkedList.DoublyLinkedList
{
    internal class DoublyLinkedList
    {
        Node head;

        /// <summary>
        /// Insert a node at first position in doubly linked list
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            newNode.next = head;
            newNode.prev = null;

            if(head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }


        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            newNode.next = null;

            if (head == null)
            {
               head = newNode;
                newNode.prev = null;
                return;
            }

            Node curr = head;

            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = newNode;
            newNode.prev = curr;
        }


        /// <summary>
        /// Traverse and display the node value from start to end
        /// </summary>
        public void Display()
        {
            Node curr = head;

            while(curr != null)
            {
                Console.WriteLine(curr.value + " -> ");
                curr = curr.next;
            }
            Console.WriteLine("END");
        }



        /// <summary>
        /// Node of doubly linked list
        /// </summary>
        public class Node
        {
            public Node next;
            public Node prev;
            public int value;

            public Node(int value)
            {
                this.value = value;
            }
            public Node(int value, Node next, Node prev)
            {
                this.value=value;
                this.next = next;
                this.prev = prev;
            }
        }
    }
}
