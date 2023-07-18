namespace LinkedList.SinglyLinkedList
{
    /// <summary>
    /// This class represents Singly linked list implementation
    /// </summary>
    internal class LinkedList
    {
        // Represents First node of the linked list
        private Node start;

        public LinkedList()
        {
            start = null;
        }

        /// <summary>
        /// Linked list traversal
        /// </summary>
        public void Display()
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node curr = start;

            while(curr != null)
            {
                Console.WriteLine(curr.key + " ");
                curr = curr.link;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Searching in Singly linked list
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Search(int key)
        {
            int position = 1;
            Node curr = start;

            while(curr != null)
            {
                if (curr.key == key)
                    break;

                position++;
                curr = curr.link;
            }

            // if linkedlist is traversed till the end, means there is no node present int the list
            if (curr == null)
                return -1;

            return position;
        }

        /// <summary>
        /// Length of the linkedlist
        /// </summary>
        /// <returns></returns>
        public int Length() {
            
            int length = 0;
            Node curr = start;

            while (curr != null)
            {
                length++;
                curr = curr.link;
            }
            return length;
        }

        /// <summary>
        /// Find the reference to last node of the linkedlist
        /// </summary>
        /// <returns></returns>
        public Node FindRefrenceToLastNode()
        {
            Node curr = start;
            while(curr.link != null)
            {
                curr = curr.link;
            }
            return curr;
        }

        /// <summary>
        /// Find the reference to second last node the linkedlist
        /// </summary>
        /// <returns></returns>
        public Node FindReferenceToSecondLastNode()
        {
            Node curr = start;

            while (curr.link.link != null)
            {
                curr = curr.link;
            }
             
            return curr;
        }

        /// <summary>
        /// Find node reference of the given key in the linkedlist
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node FindReferenceNodeOfKey(int key)
        {
            Node curr = start;

            while(curr != null) {

                if (curr.key == key)
                    break;

                curr = curr.link;
            }

            return curr;
        }

        /// <summary>
        /// Find reference to predecessor of a node with particular key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node FindPredecessorNodeOfKey(int key)
        {
            Node curr = start;

            while(curr.link != null) {
                if(curr.link.key == key)
                    break;

                curr = curr.link;
            }

            return curr;
        }

        /// <summary>
        /// Find reference to a node at a particular position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Node FindReferenceNodeAtGivenPosition(int position)
        {
            Node curr = start;
            for (int i = 1; i < position && curr != null; i++)
            {
                curr = curr.link;
            }
            return curr;
        }

        #region

        // INSERTION
        
        /// <summary>
        /// Insert a node at the beginning of the list
        /// </summary>
        /// <param name="key"></param>
        public void InsertAtBeginning(int key)
        {
            Node newNode = new Node(key);

            // New node will pointing to start, order is important
            newNode.link = start;
            start = newNode; // new start is newly added node
        }

        /// <summary>
        /// Insert a node at last of the linked list
        /// </summary>
        /// <param name="key"></param>
        public void InsertAtLast(int key)
        {
            Node newNode = new Node(key);

            // If list is empty, start will get a new node
            if(start == null)
            {
                start = newNode;
                return;
            }

            Node current = start;

            // Find the reference of the last node

            while (current.link != null)
            {
                current = current.link;
            }

            // the link part if the last node referring to new Node
            current.link = newNode;
        }

        /// <summary>
        /// Insert after a given node
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void InsertNodeAfterGivenNode(int key, int value)
        {
            Node newNode = new Node(key);

            // Search the given Node value

            Node current = start;

            while(current != null)
            {
                if (current.key == value)
                    break;

                current = current.link;
            }

            // if the current is null, means that given value is not present in the list
            if(current == null)
            {
                Console.WriteLine($"{value} is not present in the liked list");
                return;
            }

            newNode.link = current.link;
            current.link = newNode;
        }

        /// <summary>
        /// Insert before a given node
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void InsertNodeBeforeGivenNode(int key, int value)
        {
            Node newNode = new Node(key);

            // If list is empty

            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if the given value is present at the first node itself, new node will be the first node of the linkedlist
            if(value == start.key)
            {
                newNode.link = start;
                start = newNode;
                return;
            }

            // Find the reference to the predecessor of node containing the value
            Node curr = start;

            while (curr.link != null) {
                
                if(curr.key == value)
                    break;
                curr = curr.link;
            }

            // if the current is null, means that given value is not present in the list
            if (curr.link == null)
            {
                Console.WriteLine($"{value} is not present in the liked list");
                return;
            }

            newNode.link = curr.link;
            curr.link = newNode;
        }

        /// <summary>
        /// Insert at node at give position
        /// </summary>
        /// <param name="key"></param>
        /// <param name="pos"></param>
        public void InsertAtPosition(int key, int pos) {
            
            Node newNode = new Node(key);

            // Node to be inserted at Beginning( of the list
            if (pos == 1)
            {
                newNode.link = start;
                start = newNode;
                return;
            }

            Node curr = start;

            // Find the reference of pos - 1

            int i;
            for (i = 1; i < pos-1 && curr != null ; i++)
            {
                curr = curr.link;
            }

            if(curr == null)
            {
                Console.WriteLine($"You can insert up to {i} position");
                return;
            }

            newNode.link = curr.link;
            curr.link = newNode;
        }

        #endregion

        #region
        // DELETION

        /// <summary>
        /// Delete first node from the linked list
        /// </summary>
        public void RemoveFirstNode()
        {
            if (start == null)
                return;

            start = start.link;
        }

        /// <summary>
        /// Remove the last node of the list
        /// </summary>
        public void RemoveLastNode()
        {
            if (start == null) 
                return;

            if (start.link == null)
                return;

            Node current = start;

            // Find second last of the node
            while(current.link.link != null)
            {
                current = current.link;
            }
            current.link = null;
        }

        /// <summary>
        /// Delete the node which has the give key
        /// </summary>
        /// <param name="key"></param>
        public void Remove(int key)
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if key is present at the first node
            if(start.key == key)
            {
                start = start.link;
                return;
            }

            // Deletion in between or at the end
            Node curr = start;

            while (curr.link != null) {
                if (curr.link.key == key)
                    break;
                curr = curr.link;
            }

            // If key is not present in the list

            if(curr.link == null)
            {
                Console.WriteLine($"{key} is not present in the liked list, therefore, can't delete");
                return;
            }

            curr.link = curr.link.link;
        }

        #endregion

        #region
        // SOME OTHER OPERATION - Reversal, Sorting


        /// <summary>
        /// Reverse a list using while loop
        /// </summary>
        public void Reverse()
        {
            Node prev, next;
            prev = null;
            Node current = start;

            while(current != null)
            {
                // TRY TO MEMORISE: STANDARD ALOGRITHM, IT'S DIFFICULT TO COMEUP WITH THIS ALGORITHM DURING INTERVIEW
                // TRICK IS N->C->P->C 
                next = current.link;
                current.link = prev;
                prev = current;
                current = next;
            }
            start = prev;
        }
        #endregion
    }
}
