 namespace Searching.AdityaPlayList
{
    /// <summary>
    /// Find First and Last occurrence of Element
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    internal class FirstAndLastOccurrence
    {
        /// <summary>
        /// this will find the first occurance of the given element
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
       public int FindFirstIndex(int[] nums, int key)
       {
            int start = 0;
            int end = nums.Length - 1;
            int index = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == key)
                    index = mid;

                if(nums[mid] >= key)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return index;
       }
    }
}
