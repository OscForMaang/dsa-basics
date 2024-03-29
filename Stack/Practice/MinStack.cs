namespace Stack.Practice
{
    internal class MinStack
    {
        Stack<int> stack;
        int min;
        public MinStack()
        {
            stack = new Stack<int>();
            min = 0;
        }

        public void Push(int val)
        {
            if(stack.Count == 0)
            {
                min = val;
            }else
            {
                if(min < val)
                {
                    val = 2 * val - min;
                }
            }
            stack.Push(val);
        }

        public void Pop()
        {
            if (stack.Count == 0)
                return;

            if(stack.Peek() >= min)
                stack.Pop();
            else
            {
                // need to modify the min
                // flag
                min = 2 * min - stack.Peek();
                stack.Pop();
            }
        }

        public int Top()
        {
            if (stack.Count == 0)
                return -1;

            if (stack.Peek() >= min)
                return stack.Peek();
            else
                return min;
        }

        public int GetMin()
        {
            if(stack.Count == 0)
                return -1;

            return min;
        }
    }
}
