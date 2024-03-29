namespace Searching.AdityaPlayList
{
    internal class RotatedArray
    {
        /// <summary>
        /// Index of Minimum element : Index of Pivot elemen
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumberOfRotation(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            if (nums[0] <= nums[end])
                return start;

            int len = nums.Length;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if(nums[mid] < nums[(mid + len - 1) % len] 
                    && nums[mid] < nums[(mid + 1) % len])
                {
                    return mid;
                }  
                else if(nums[mid] <= nums[end])
                {
                    end = mid - 1;
                }
                else if (nums[mid] >= nums[start])
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
