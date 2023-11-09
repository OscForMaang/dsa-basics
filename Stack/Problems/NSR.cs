namespace Stack.Problems
{
    internal class NSR
    {
        /// <summary>
        /// Nearest Smaller RIGHT
        /// </summary>
        /// <param name="arr"></param>
        public void PrintNSR(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            // traverse Right to left 
            for (int i = arr.Length-1; i >= 0; i--)
            {
                // If stack is empty, there is nothing to check in left direct
                if (stack.Count == 0)
                {
                    Console.WriteLine(-1);
                }
                else if (stack.Count > 0 && stack.Peek() < arr[i])
                {
                    Console.WriteLine(stack.Peek());
                }
                else if (stack.Count > 0 && stack.Peek() > arr[i])
                {
                    while (stack.Count > 0 && stack.Peek() < arr[i])
                    {
                        stack.Pop();
                    }
                }
                stack.Push(arr[i]);
            }
        }
    }
}
