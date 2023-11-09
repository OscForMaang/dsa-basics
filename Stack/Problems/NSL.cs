namespace Stack.Problems
{
    internal class NSL
    {
        /// <summary>
        /// Nearest Smaller Left
        /// </summary>
        /// <param name="arr"></param>
        public void PrintNSL(int[] arr)
        {
            Stack<int> stack = new Stack<int>();

            // traverse Left to Right 

            for (int i = 0; i < arr.Length; i++)
            {
                // If stack is empty, there is nothing to check in left direct
                if(stack.Count == 0)
                {
                    Console.WriteLine(-1);
                }
                else if(stack.Count > 0 && stack.Peek() < arr[i]) 
                {
                    Console.WriteLine(stack.Peek());
                }
                else if(stack.Count > 0 && stack.Peek() > arr[i])
                {
                    while(stack.Count > 0 && stack.Peek() < arr[i])
                    {
                        stack.Pop();
                    }
                }
                stack.Push(arr[i]);
            }
        }
    }
}
