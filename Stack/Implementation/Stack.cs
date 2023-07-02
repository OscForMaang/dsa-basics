namespace Stack.Implementation
{
    internal class Stack
    {
        /*
         *  LIFO : Last in first out
         *      For empty stack : top = -1
         *  Push: To add an element
         *       top is increased by 1
         *       New index is placed at index top
         *  Pop : Removing element
         *       Element at index top taken out
         *       top is decreased by 1
         *  Peek Element : Return element at the top
         */

        int top; // indicates the top of the stack
        int[] stack; // array to store element in the stack data structure

        public Stack()
        {
            top = -1;
            stack = new int[10];
        }

        public Stack(int size)
        {
            top = -1;
            stack = new int[size];
        }

        /// <summary>
        /// returns the size of the stack
        /// </summary>
        /// <returns></returns>
        public int Size() {
            return top + 1;
        }

        /// <summary>
        /// returns true if stack is full other wise false
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return top == stack.Length - 1;
        }

        /// <summary>
        /// return true if the stack is empty otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return top == -1;
        }

        /// <summary>
        /// Add the element to the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {

            if(IsFull())
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            top++;
            stack[top] = value;
        }

        /// <summary>
        /// Returns top element of the stack and remove it from the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }

            int value = stack[top];
            top--;
            return value;
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
            return stack[top];
        }

        /// <summary>
        /// Display the elements of stack
        /// </summary>
        public void Display() {

            if (IsFull())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
