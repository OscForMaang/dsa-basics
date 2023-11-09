namespace Stack.Problems
{
    public class MinStack
    {

        Stack<int> stack;
        Stack<int> minStack;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }
        public void Push(int val)
        {
            stack.Push(val);
            if (minStack.Count == 0 || minStack.Peek() >= val)
            {
                minStack.Push(val);
            }
        }
        public void Pop()
        {
            if (stack.Count > 0)
            {
                int val = stack.Pop();
                if (val == minStack.Peek())
                {
                    minStack.Pop();
                }
            }
        }

        public int Top()
        {
            if (stack.Count == 0)
            {
                return -1;
            }
            return stack.Peek();
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
            {
                return -1;
            }
            return minStack.Peek();
        }
    }
}
