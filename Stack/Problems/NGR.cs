namespace Stack.Problems
{
    internal class NGR
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/next-greater-element/
        /// </summary>
        /// <param name="arr"></param>
        public void PtintNGR(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            // we will start from end 
            for (int i = arr.Length -1; i >= 0; i--)
            {
                if(stack.Count == 0)
                {
                    Console.WriteLine(-1);

                }else if(stack.Count > 0  && stack.Peek() > arr[i])
                {
                    Console.WriteLine(stack.Peek());
                }
                else if (stack.Count > 0 && stack.Peek() < arr[i])
                {
                    while(stack.Count > 0 && stack.Peek() < arr[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(stack.Peek());
                    }
                }
                stack.Push(arr[i]);
            }
        }
    }
}
