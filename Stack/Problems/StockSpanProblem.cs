namespace Stack.Problems
{
    internal class StockSpanProblem
    {
        static void CalculateStackSpan(int[] arr)
        {
            Stack<Dictionary<int, int>> stack = new Stack<Dictionary<int, int>>();

            int[] result = new int[arr.Length];

            // We to find nearest greater to left : NGL 
            for (int i = 0; i < arr.Length; i++)
            {

                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else if (stack.Count > 0 && stack.Peek().First().Value > arr[i])
                {
                    result[i] = i;
                }
                else if(stack.Count > 0 && stack.Peek().First().Value < arr[i])
                {
                    while(stack.Count > 0 && stack.Peek().First().Value <= arr[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        result[i] = -1;
                    }
                    else
                    {
                        result[i] = stack.Peek().First().Key;
                    }
                }
                stack.Push(new Dictionary<int, int>() { { i, arr[i] } });
            }

            // Print stock span 
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(i - arr[i]);
            }
        }
    }
}
