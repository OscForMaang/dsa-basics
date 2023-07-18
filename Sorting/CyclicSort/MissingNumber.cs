namespace Sorting.CyclicSort
{
    internal class MissingNumber
    {
        /// <summary>
        /// Given 0 to n numbers in an array but one number is missing, find that missing number
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMissingNumber(int[] nums)
        {
            int start = 0;
            int len = nums.Length;

            // cyclic sort
            while(start < len)
            {

                if (nums[start] < len && nums[start] != nums[nums[start]]) { 
                    int temp = nums[start];
                    nums[start] = nums[nums[start]];
                    nums[nums[start]] = temp;
                }
                else
                {
                    start++;
                }
            }

            int res = 0;

            for(int i = 0; i < len; i++)
            {
                if (nums[i] != i)
                    return i;
            }

            // CASE 2: Nth is missing
            return len;
        }
    }
}
