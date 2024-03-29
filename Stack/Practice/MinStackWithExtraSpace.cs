namespace Stack.Practice
{
    public class MinStackWithExtraSpace
    {
        Stack<int> minStak;
        Stack<int> stack;
        public MinStackWithExtraSpace()
        {
            minStak = new Stack<int>();
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            if(stack.Count == 0)
            {
                minStak.Push(val);
            }
            else
            {
                if(val <= minStak.Peek())
                {
                    minStak.Push(val);
                }
            }
            stack.Push(val);

        }

        public void Pop()
        {
            int top = stack.Pop();
            if(top == minStak.Peek()) 
                minStak.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStak.Peek();
        }
    }
}
