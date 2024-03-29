namespace Searching.AdityaPlayList
{
    internal class BinarySearch
    {
        /// <summary>
        /// Binary search : nums Array is sorted in ascending order
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchAsc(int[] nums, int key)
        {
            int start = 0; ;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] > key)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }

        /// <summary>
        /// Binary search : nums Array is sorted in descending order
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchDesc(int[] nums, int key)
        {
            int start = 0;
            int end = nums.Length - 1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] > key)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }

        /// <summary>
        /// Binary search : Order is unknown
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int OrderAgnosticSearch(int[] nums, int key)
        {
            bool isAsc = nums[0] <= nums[nums.Length - 1];
            if(isAsc)
                return SearchAsc(nums, key);
            else
                return SearchDesc(nums, key);
        }
    }
}
