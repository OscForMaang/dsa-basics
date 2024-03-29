namespace Stack.Practice
{
    internal class StackBasic
    {
        /// <summary>
        /// Next largest element 
        /// Nearest greater to right
        /// Iterative algorithms
        /// </summary>
        /// <param name="nums"></param>
        public int[] NextLarestElement(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int end = nums.Length - 1;
            int[] res = new int[nums.Length];
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if(stack.Count == 0)
                {
                    res[end] = -1;
                }
                else if(stack.Count > 0 && stack.Peek() > nums[i])
                {
                    res[end] = stack.Peek();
                }
                else if(stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    while(stack.Any() && stack.Peek() <= nums[i])
                    {
                        stack.Pop();
                    }
                    if(stack.Count == 0)
                    {
                        nums[end] = -1;
                    }
                    else
                    {
                        nums[end] = stack.Peek();
                    }

                }
                end--;
                stack.Push(nums[i]);
            }  
            
            return res;
        }

        /// <summary>
        /// NearestGreaterToLeft
        /// </summary>
        /// <param name="nums"></param>
        public int[] NearestGreaterToLeft(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                if(stack.Count == 0)
                {
                    result[i] = -1;
                }else if(stack.Count > 0 && stack.Peek() > nums[i])
                {
                    result[i] = stack.Peek();
                }else if(stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    while(stack.Any() && stack.Peek() <= nums[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        result[i] = -1;
                    }
                    else
                    {
                        result[i] = stack.Peek();
                    }
                }
                stack.Push(nums[i]);
            }
            return result;
        }

        /// <summary>
        /// NearestSmallerToLeft
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] NearestSmallerToLeft(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int[] result = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else if(stack.Count > 0 && stack.Peek() < nums[i])
                {
                    result[i] = stack.Peek();
                }else if(stack.Count > 0 && stack.Peek() > nums[i])
                {
                    while(stack.Count > 0 && stack.Peek() >= nums[i])
                    {
                        stack.Pop();
                    }
                    if(stack.Count == 0)
                    {
                        nums[i] = -1;
                    }
                    else
                    {
                        nums[i] = stack.Peek();
                    }
                }
                stack.Push(nums[i]);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] NearestSmallerToRight(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int[] result = new int[nums.Length];

            int start = 0;

            for(int i = nums.Length-1; i >=0; i--)
            {
                if(stack.Count == 0)
                {
                    result[start] = -1;

                }else if(stack.Count > 0 && nums[i] > stack.Peek())
                {
                    result[start] = stack.Peek();
                }else if(stack.Count > 0 && nums[i] <= stack.Peek())
                {
                    while(stack.Count > 0 && stack.Peek() >= nums[i])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        result[start] = -1;
                    }
                    else
                    {
                        result[start] = stack.Peek();
                    }
                }
                start++;
                stack.Push(nums[i]);
            }
         
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/next-greater-element-i/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
           

            Dictionary<int, int> nextGreaterElement = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            for(int index = nums2.Length-1; index >= 0; index--)
            {
                if(stack.Count == 0)
                {
                    nextGreaterElement.Add(nums2[index], -1);
                }
                else if( stack.Count > 0 && stack.Peek() > nums2[index])
                {
                    nextGreaterElement.Add(nums2[index], stack.Peek());
                }else if(stack.Count > 0 && stack.Peek() <= nums2[index])
                {
                    while(stack.Any() && stack.Peek() <= nums2[index])
                    {
                        stack.Pop();
                    }

                    if(stack.Count == 0)
                    {
                        nextGreaterElement.Add(nums2[index], -1);
                    }
                    else
                    {
                        nextGreaterElement.Add(nums2[index],stack.Peek());
                    }
                }
                stack.Push(nums2[index]);
            }         

            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = nextGreaterElement[nums1[i]];
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/next-greater-element-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];
            Stack<int> stack = new Stack<int>();
            // Adding element from n-2 till 1
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                stack.Push(nums[i]);
            }
            int start = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (stack.Count == 0)
                {
                    result[start] = -1;
                }
                else if (stack.Count > 0 && stack.Peek() > nums[i])
                {
                    result[start] = stack.Peek();
                }
                else if (stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    while (stack.Any() && stack.Peek() <= nums[i])
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        result[i] = -1;
                    }
                    else
                    {
                        result[start] = stack.Peek();
                    }
                }
                start--;
                stack.Push(nums[i]);
            }
            return result;
        }
    }

}
