namespace Sorting.BubbleSort
{
    internal class BubbleSort
    {
        /*
         * Comparison based sorting algo, also known as sinking sort or exchange sort
         * In every pass largest element is placed at last
         * Time Complexity : O(N^2)
         * Space Complexity : O(1)
         * For ith pass, ith element from end would be sorted 
         * In Place is sorted
         * Stable sorting
         */

        /// <summary>
        /// Sort an array using bubble sort
        /// </summary>
        /// <param name="nums"></param>
        public void Sort(int[] nums) {

            int len = nums.Length;

            // run the steps n-1 times
            for (int i = 0; i < len; i++)
            {
                bool isSwapped = false;

                // for each step, max item come at the last respective index
                for (int j = 0; j < len - i - 1; j++) // for ith pass, ith element from end of array would be sorted
                {
                    
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[i] = nums[j + 1];
                        nums[j + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped) // array was already sorted
                {
                    break;
                }
            }
        }
    }
}
