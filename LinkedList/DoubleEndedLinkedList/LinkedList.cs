namespace LinkedList.DoubleEndedLinkedList
{
    public class LinkedList
    {
        // this linked is also called double headed linked list
        private Node head;
        private Node tail;

        private int size; // keep track of number of node in the linked list

        public LinkedList()
        {
           this.size = 0;
        }

        /// <summary>
        /// Add an element at head of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            // if is null, means linked list was empty
            if(tail == null)
            {
                tail = head;
            }
            size++;
        }

        /// <summary>
        /// add an element at the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(int value)
        {

            if(tail == null)
            {
                AddFirst(value);
                return;
            }
            Node newNode = new Node(value);
            tail.next = newNode;
            tail = newNode;
            size++;
        }

        /// <summary>
        /// Add an element at the given index
        /// </summary>
        /// <param name="key"></param>
        /// <param name="index"></param>
        public void AddAtIndex(int key, int index)
        {
            if(index == 0)
            {
                AddFirst(key);
                return;
            }

            if(index == size)
            {
                AddLast(key);
                return;
            }

            Node curr = head;

            for(int i = 1; i < size; i++)
            {
                curr = curr.next;
            }

            Node newNode = new Node(key);
            newNode.next = curr.next;
            curr.next = newNode;
            size++;
        }

        /// <summary>
        /// Delete the first node from the linked list
        /// </summary>
        /// <returns></returns>
        public int DeleteFirst()
        {
            int val = head.value;
            head = head.next;

            if (head == null)
                tail = null;

            size--;
            return val;
        }

        /// <summary>
        /// Delete last node from the linked list
        /// </summary>
        /// <returns></returns>
        public int DeleteLast()
        {
            if(size <= 1)
            {
                return DeleteFirst();
            }

            Node secondLast = GetNode(size - 2);
            int val = secondLast.value;

            tail = secondLast;
            tail.next = null;
            size--;
            return val;
        }

        /// <summary>
        /// Delete the node at given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Delete(int index)
        {
            if(index == 0)
            {
                return DeleteFirst();
            }

            if(index == size - 1)
            {
                return DeleteLast();
            }

            Node prev = GetNode(size - 1);
            int val = prev.next.value;

            prev.next = prev.next.next;
            size--;
            return val;
        }


        /// <summary>
        /// Give the reference of the first node with given value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node FindNode(int value)
        {
            Node curr = head;

            while (curr != null)
            {
                if (curr.value == value)
                    return curr;

                curr = curr.next;
            }

            // Value not found
            return null;
        }

        /// <summary>
        /// Get the node reference at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Node GetNode(int index)
        {
            Node curr = head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.next;
            }

            return curr;
        }


        /// <summary>
        /// Insert a an element at a given index using recursion
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void Insert(int value, int index)
        {

        }

        /// <summary>
        /// Node implementation of a linked list
        /// </summary>
        public class Node
        {
            public int value;
            public Node next;

            public Node(int key)
            {
                this.value = key;
            }

            /// <summary>
            /// Newly created node will point to parameter next node
            /// </summary>
            /// <param name="value"></param>
            /// <param name="next"></param>
            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }
    }
}
