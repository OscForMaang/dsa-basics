namespace Stack.Implementation
{
    internal class LinkedListStack
    {
        /*
         * Beginning of the linked list: top of the stack
         * Push: Node is inserted in the beginning of the list
         * Pop: First node of the list is deleted
         */

        Node top;
        public LinkedListStack()
        {
            top = null; // refers the top of the stack
        }

        /// <summary>
        /// Returns the number of elements in the stack
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int size = 0;
            Node curr = top;

            while (curr != null)
            {
                curr = curr.link;
                size++;
            }

            return size;
        }

        /// <summary>
        /// return true if stack is empty otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return top == null;
        }

        /// <summary>
        /// push an element to the stack
        /// </summary>
        /// <param name="key"></param>
        public void Push(int key)
        {
            Node newNode = new Node(key);
            newNode.link = top;
            top = newNode;
        }

        /// <summary>
        /// returns top element of the stack and remove it from the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }

            int key = top.key;
            top = top.link;
            return key;
        }
        /// <summary>
        /// Returns the top top element of the stack without removing it
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return top.key;
        }

        /// <summary>
        /// Display the elements of stack
        /// </summary>
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }

            Node curr = top;
            while (curr != null) {
                Console.WriteLine(curr.key + " ");
                curr = curr.link;
            }
            Console.WriteLine();
        }
    }
}
