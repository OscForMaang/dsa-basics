namespace Searching.BinarySearchPractice
{
    internal class BinarySearchRange
    {
        /// <summary>
        /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            if (end == 0)
            {
                if (nums[start] == target)
                    return new int[] { start, end };
                else
                    return new int[] { -1, -1 };
            }

            int left = Search(nums, start, end, true, target);
            int right = Search(nums, start, end, false, target);

            return new int[] { left, right };
        }

        private int Search(int[] nums, int start, int end, bool isLeft, int target)
        {
            int result = -1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    if (isLeft)
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                 
                else if (nums[mid] > target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return result;
        }
    }
}
