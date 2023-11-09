namespace Stack.Problems
{
    internal class NGL
    {
        public void PrintGNL(int[] arr)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(stack.Count == 0)
                {
                    Console.WriteLine(arr[i]);
                }else if(stack.Count > 0 &&  stack.Peek() > arr[i])
                {
                    Console.WriteLine(stack.Peek());
                }

                else if(stack.Count > 0 && stack.Peek() < arr[i])
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
