namespace Queue.Implementation
{
    /// <summary>
    /// Queue implementation using Linked list
    /// </summary>
    internal class LinkedListQueue
    {
        /*
         * Linked list implementation of Queue
         *  Beginning of list : Front end of the queue
         *  End of the list: Read end of the queue
         *  Insertion : Add a node at the end of the list
         *      rear.link = newNode;
         *      rear = newNode
         *  Deletion : Delete a node from the beginning of the list
         *      front = front.link
         *  For this purpose : we will be using the double ended or headed linked list
         */

        Node front;
        Node rear;

        public LinkedListQueue()
        {
            front = null;
            rear = null;
        }

        /// <summary>
        /// Returns true of the Queue is empty otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return front == null;
        }

        /// <summary>
        /// Returns the size of the queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int size = 0;
            Node curr = front;
            while (curr != null)
            {
                size++;
                curr = curr.link;
            }

            return size;
        }

        /// <summary>
        ///  Insert an element in the queue
        /// </summary>
        /// <param name="key"></param>
        public void Enqueue(int key)
        {
            Node newNode = new Node(key);
            if (IsEmpty())
                front = newNode;
            else
                rear.link = newNode;

            rear = newNode;
        }

        /// <summary>
        ///  Delete an element from the queue
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is underflow");
            }

            // Dequeue happens at the front end of the linked list

            int key = front.key;
            front = front.link;
            return key;
        }

        /// <summary>
        /// returns the queue element from front
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is underflow");
            }

           return front.key; ;
        }

        /// <summary>
        /// Prints the elements of the linked list
        /// </summary>
        public void Display()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node curr = front;
            Console.WriteLine("Queue is : \n\n");
            while (curr != null)
            {
                Console.WriteLine(curr.key + " ");
                curr = curr.link;
            }

            Console.WriteLine();
        }
    }
}
