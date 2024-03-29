namespace Recursion.Practice
{
    internal class MaximumAreaOfHistogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            int[] nearestSmallerToLeft = new int[heights.Length];
            int[] nearestSmallerToRight = new int[heights.Length];
            Stack<(int, int)> rightStack = new Stack<(int, int)>();
            Stack<(int, int)> leftStack = new Stack<(int, int)>();
            int end = heights.Length - 1;
            for (int start = 0; start < heights.Length && end >= 0; start++)
            {

                // Calculate nearest smaller element index towards left
                if (leftStack.Count == 0)
                {
                    nearestSmallerToLeft[start] = 0;
                }
                else
                {

                    if (leftStack.Peek().Item1 < heights[start])
                    {
                        nearestSmallerToLeft[start] = start;
                    }
                    else
                    {
                        while (leftStack.Any() && leftStack.Peek().Item1 >= heights[start])
                        {
                            leftStack.Pop();
                        }
                        if (leftStack.Count == 0)
                        {
                            nearestSmallerToLeft[start] = 0;
                        }
                        else
                        {
                            nearestSmallerToLeft[start] = leftStack.Peek().Item2 + 1;
                        }
                    }
                }

                leftStack.Push((heights[start], start));
                // Calculate nearest smaller element index towards right
                if (rightStack.Count == 0)
                {
                    nearestSmallerToRight[end] = heights.Length-1;
                }
                else
                {
                    if (rightStack.Peek().Item1 < heights[end])
                    {
                        nearestSmallerToRight[end] = end;
                    }
                    else
                    {
                        while (rightStack.Any() && rightStack.Peek().Item1 >= heights[end])
                        {
                            rightStack.Pop();
                        }
                        if (rightStack.Count == 0)
                        {
                            nearestSmallerToRight[end] = heights.Length - 1;
                        }
                        else
                        {
                            nearestSmallerToRight[end] = rightStack.Peek().Item2 - 1;
                        }
                    }
                }
                rightStack.Push((heights[end], end));
                end--;
            }
            int max = -1;
            for (int i = 0; i < heights.Length; i++)
            {
                max = Math.Max(max, (Math.Abs(nearestSmallerToLeft[i] - nearestSmallerToRight[i]) + 1) * heights[i]);
            }
            return max;

        }

    }
}
