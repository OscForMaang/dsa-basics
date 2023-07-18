namespace Searching.Implementation
{
    internal class BinarySearch
    {
        /*
         * Binary Search : Used to search a target number in a sorted array
         * Time Complexity: O(log(n)), n ---> size of array
         * Space Complexity: O(1)
         */

        /// <summary>
        /// return the index of target element if the target found the array otherwise -1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while(start <= end)
            {
                // find the middle element between start and end index
                int mid = start + (end - start) / 2; // to avoid integer value overflow, star t + end may exceed the int size 
                // target is found at middle, return the mid
                if (arr[mid] == target)
                    return mid;
                // if target is greater than mid element, means target is present at right of mid
                else if (target > arr[mid]) 
                    start = mid + 1;
                // if target is less than mid element, means target is present at left of mid
                else
                    end = mid - 1;
            }
            // while loop has ended, but element doesn't found - target element is not present in the list or array
            return -1;
        }


        // Binary Search using recursion
        /// <summary>
        /// return true if the target found the array otherwise false, recursive binary search
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool RecursiveBinarySearch(int[] arr, int target)
        {
            return Search(arr, target, 0, arr.Length - 1) != -1;
        }

        private int Search(int[] arr, int target, int start, int end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] == target)
                return mid;
            else if(target > arr[mid])
                return Search(arr, target, mid + 1, end);
            else
                return Search(arr, target, start, mid - 1);
        }
    }
}
