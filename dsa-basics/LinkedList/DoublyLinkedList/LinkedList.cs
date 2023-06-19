namespace LinkedList.DoublyLinkedList
{
    /// <summary>
    /// Doubly linked list implementation
    /// </summary>
    internal class LinkedList
    {
        Node start;
        public LinkedList()
        {
            start = null;
        }

        #region

        /// <summary>
        /// Insert a node with value key at the start of the doubly linked list
        /// </summary>
        /// <param name="key"></param>
        public void InsertAtBeginning(int key)
        {
            Node newNode = new Node(key);

            // If the list is empty 
            if (start == null)
            {
                start = newNode;
                return;
            }

            // New node will become the start/head of the linked list
            // and the current start will become the 2nd node of the doubly linked list
            newNode.next = start;
            start.prev = newNode; // linking the previous of head/start node to the newly created node
            start = newNode; // Newly created node is the new start
        }

        /// <summary>
        /// Insert a new node with value key at the end of the doubly linked list
        /// </summary>
        /// <param name="key"></param>
        public void InsertAtEnd(int key)
        {
            Node newNode = new Node(key);

            // If the node is empty, newly created node will become the new the head/start of the linked list
            if(start == null)
            {
                start = newNode;
                return;
            }

            // Since we have to add the node at the last, traverse till end of the list
            Node current = start;
            while (current.next != null)
            {
                current = current.next;
            }

            // next of the last node the linked list will refer to newly created list
            current.next = newNode;
            newNode.prev = current; // previous link of the newly created node will refer to last node
        }

        /// <summary>
        /// Insert a node with value x after a node with value key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void InsertAfter(int key, int x)
        {

            Node newNode = new Node(x);

            Node current = start;

            while (current != null)
            {
                if (current.key == key)
                    break;
                current = current.next;
            }

            // if we have traversed till end- means key is not present in the list

            if (current == null)
            {
                Console.WriteLine($"{key} is not present in the list");
                return;
            }

            newNode.prev = current;
            newNode.next = current.next;

            // if the key is the last node
            if (current.next == null)
                current.next.prev = newNode;

            current.next = newNode;
        }

        /// <summary>
        /// Insert a node with value x before a node with value key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="x"></param>
        public void InsertBefore(int key, int x)
        {
            Node newNode = new Node(x);

            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // If the key is present at the first position, Node to be inserted at the beginning 
            if(start.key == key)
            {
                newNode.next = start;
                start.prev = newNode;
                start = newNode;

                return;
            }

            Node current = start;

            while(current != null)
            {
                if (current.key == key)
                    break;
                current = current.next;
            }

            // if we have traversed till end- means key is not present in the list
            if(current == null)
            {
                Console.WriteLine($"{key} is not present in the list");
                return;
            }

            // Insert a node before the current node
            newNode.prev = current.prev;
            newNode.next = current;
            current.prev.next = newNode;
            current.prev = newNode;
        }

        #endregion

        #region

        /// <summary>
        /// Delete First node of the doubly linked list
        /// </summary>
        public void DeleteFirstNode()
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // If the list has only one node, after deletion, we will have empty or null list
            if(start.next == null)
            {
                start = null;
                return;
            }

            start = start.next;
            start.prev = null;
        }

        public void DeleteLastNode()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // If the list has only one node, after deletion, we will have empty or null list
            if (start.next == null)
            {
                start = null;
                return;
            }

            // traverse till end of the linked list
            Node current = start;
            while(current.next != null)
            {
                current = current.next;
            }

            current.prev.next = null;
        }

        /// <summary>
        /// Delete a node with value key from the doubly linked list
        /// </summary>
        /// <param name="key"></param>
        public void DeleteNode(int key)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if the list has only one node 

            if (start.next == null)
            {
                if(start.key == key)
                    start = null;
                else
                    Console.WriteLine($"{key} is not present in the list");

                return;
            }

            // if the key is present at the start node of the linked list
            if(start.key == key)
            {
                start = start.next;
                start.prev = null;
                return;
            }

            Node current = start.next;

            while(current.next != null)
            {
                if (current.key == key)
                    break;
                current = current.next;
            }

            // CASE: 1 Node to be deleted is in between

            if(current.next != null)
            {
                current.prev.next = current.next;
                current.next.prev = current.prev;
                return;
            }
            else
            {
                // CASE: 2 Current refers to last node of the list

                if(current.key == key)
                    current.prev.next = null; // Node to be deleted is the last node of the linked list
                else
                    Console.WriteLine($"{key} is not present in the list");

            }
        }
        #endregion

        #region


        /// <summary>
        /// Reverse Doubly linked list using while loop
        /// </summary>
        public void Reverse()
        {

            Node curr1 = start;
            Node curr2 = curr1.next;

            curr1.next = null;
            curr1.prev = curr2;

            while(curr2 != null)
            {
                curr2.prev = curr2.next;
                curr2.next = curr1;
                curr1 = curr2;
                curr2 = curr2.prev;
            }

            start = curr1;
        }

        #endregion
    }
}
