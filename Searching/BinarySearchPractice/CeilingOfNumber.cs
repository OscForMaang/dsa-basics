namespace Searching.BinarySearchPractice
{
    internal class CeilingOfNumber
    {
        // Find the smallest number in a sorted array which is greater than and equal to target element
        // [2,3,5,9,16,18] target = 15
        // Ans: 16

        /// <summary>
        /// Smallest number in a sorted array which is greater than and equal to target element
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindCeiling(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length;

            while (start <= end) {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                    return mid;
                else if(target > arr[mid])
                    start = mid + 1;
                else
                    end = mid - 1;

            }

            // while loop will break when start > end and start will point to our target element
            return start; 
        }
    }
}
