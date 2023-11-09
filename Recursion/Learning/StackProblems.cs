namespace Recursion.Learning
{
    internal class StackProblems
    {
        public Stack<int> Sort(Stack<int> stack) // Hypothesis: this will sort the stack
        {
            if(stack.Count == 1) // Base condition
            {
                return stack;
            }

            // Induction steps
            int temp = stack.Pop();
            stack = Sort(stack); // sort the stack with smaller input
            stack = Insert(stack, temp); //
            return stack;

        }

        private Stack<int> Insert(Stack<int> stack, int temp) // Hypothesis : merge temp value into sorted stack
        {
            int value = stack.Peek();

            if(stack.Count == 0 || value <= temp) // Base condition
            {
                stack.Push(value);
                return stack;
            }

            // induction step
            stack = Insert(stack, temp);
            stack.Push(value);
            return stack;
        }


        public Stack<int> DeleteMiddleElement(Stack<int> stack, int k) {

            if (k == 1)
            {
                stack.Pop();
                return stack;
            }
            int value = stack.Pop();
            stack = DeleteMiddleElement(stack, k - 1);
            stack.Push(value);
            return stack;
        }


        /// <summary>
        /// Reverse stack problem
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>

        public Stack<int> Reverse(Stack<int> stack) // will reverse the stack from 1 to n length
        {
            if (stack.Count == 1)
                return stack;

            int val = stack.Pop(); // fist element
            stack = Reverse(stack); // will reverse the stack from 2 to n 
            stack = Insert(stack, val); //Insert value at correct bottom
            return stack;
        }


        private Stack<int> InsertAtEnd(Stack<int> stack, int k) // Insert the k at the end of the stack
        {

            // Base condition
            if (!stack.Any()) // if there is no element in the stack, k will be added at the correct position
            {
                stack.Push(k);
                return stack;
            }
            // Induction steps
            int val = stack.Pop();
            stack = InsertAtEnd(stack, k); // Insert the K at the end of the stack
            stack.Push(val);
            return stack;
        }
    }
}
