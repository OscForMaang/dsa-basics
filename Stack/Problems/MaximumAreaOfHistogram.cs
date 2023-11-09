namespace Stack.Problems
{
    internal class MaximumAreaOfHistogram
    {

        /// <summary>
        /// https://leetcode.com/problems/maximal-rectangle/ 
        /// Hard problem
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int MaximalRectangle(char[][] matrix)
        {
            int[] histogram = new int[matrix[0].Length];
            int maxArea = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == '1')
                    {
                        histogram[col] += 1;
                    }
                    else
                    {
                        histogram[col] = 0;
                    }
                }

                int area = MaxinumArea(histogram);
                if (maxArea < area)
                {
                    maxArea = area;
                }
            }
            return maxArea;
        }

        public int MaximalRectagleArea(int[][] arr)
        {
            int maxArea = 0;
            // Histogram generation
            for (int row = 1; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    if (arr[row][col] != 0)
                    {
                        arr[row][col] += arr[row - 1][col];
                    }
                }

                // calculate maximum area in histogram
                int area = MaxinumArea(arr[row]);
                if(maxArea < area)
                {
                    maxArea = area;
                }
            }
            return maxArea;
        }

        public int MaxinumArea(int[] nums)
        {
            // Get NSL Index array
            // Get NSR Index array
            // Width array
            // Find Max area
            int[] NSLIndex = GetNSLIndex(nums);
            int[] NSRIndex = GetNSRIndex(nums);
            int maxArea = (NSRIndex[0] - NSLIndex[0] - 1) * nums[0]; // Height * Weight
            for (int i = 1; i < nums.Length; i++)
            {
                int area = (NSRIndex[i] - NSLIndex[i] - 1) * nums[i];
                if (maxArea < area)
                {
                    maxArea = area;
                }
            }
            return maxArea;
        }

        // Find index of nearest index to Right
        // we need to traverse from right to left
        private int[] GetNSRIndex(int[] nums)
        {
            Stack<int[]> stack = new Stack<int[]>();
            int[] NSRIndexArray = new int[nums.Length];
            for (int i = nums.Length-1; i >= 0; i--)
            {
                // if stack is empty, there is no element to right
                // In this case we will consider pseudo element with value 0
                if(stack.Count == 0)
                {
                    NSRIndexArray[i] = nums.Length;
                }else if(stack.Count > 0 && stack.Peek()[1] < nums[i])
                {
                    NSRIndexArray[i] = stack.Peek()[0]; // 1st index is having index
                }
                else
                {
                    while(stack.Count > 0 && stack.Peek()[1] >= nums[i])
                    {
                        stack.Pop();
                    }
                    if(stack.Count == 0)
                    {
                        NSRIndexArray[i] = nums.Length;
                    }
                    else
                    {
                        NSRIndexArray[i] = stack.Peek()[0];
                    }
                }

                stack.Push(new int[] { i, nums[i] });
            }

            return NSRIndexArray;
        }

        private int[] GetNSLIndex(int[] nums)
        {
            Stack<int[]> stack = new Stack<int[]>();
            int[] NSLIndexArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                // if stack is empty, there is no element to left
                // In this case we will consider pseudo element with value at left part of the array
                if (stack.Count == 0)
                {
                    NSLIndexArray[i] = -1;
                }
                else if (stack.Count > 0 && stack.Peek()[1] < nums[i])
                {
                    NSLIndexArray[i] = stack.Peek()[0]; // 1st index is having index
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek()[1] >= nums[i])
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        NSLIndexArray[i] = -1;
                    }
                    else
                    {
                        NSLIndexArray[i] = stack.Peek()[0];
                    }
                }
                stack.Push(new int[] { i, nums[i] });
            }
            return NSLIndexArray;
        }
    }
}
