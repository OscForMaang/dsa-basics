namespace Searching.AdityaPlayList
{
    internal class SingleElementProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/single-element-in-a-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNonDuplicate(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }
            if(nums.Length % 2 == 0)
            {
                return -1;
            }
            int start = 0;
            int end = nums.Length - 1;
            while(start <= end)
            {
                // int mid = (start + end) >> 1;
                int mid = start + (end - start) / 2;
                if(mid + 1 < nums.Length && mid - 1 >= 0)
                {
                    if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                        return nums[mid];

                    if (mid % 2 == 0)
                    {
                        if (nums[mid] == nums[mid + 1])
                            start = mid + 1;
                        else if (nums[mid] == nums[mid - 1])
                            end = mid - 1;
                    }
                    else
                    {
                        if (nums[mid] == nums[mid + 1])
                            end = mid - 1;
                        else if (nums[mid] == nums[mid - 1])
                            start = mid + 1;
                    }
                }
                else
                {
                    if(mid >= nums.Length-1)
                    {
                        return nums[nums.Length-1];
                    }
                    if(mid <= 0)
                    {
                        return nums[0];
                    }
                }
            }
            return -1;
        }
    }
}
