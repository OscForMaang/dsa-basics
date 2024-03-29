namespace StringArray.Arrays
{
    internal class RemoveDuplicatesProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            int left = 0;
            int right = 0;
            while(right < nums.Length)
            {
                int count = 1;
                while(right + 1 < nums.Length &&  nums[right] == nums[right + 1])
                {
                    count++;
                    right++;
                }
                for (int i = 1; i <= Math.Min(2, count); i++)
                {
                    nums[left] = nums[right];
                    left++;
                }
                right++;
            }
            return left;
        }
    }
}
