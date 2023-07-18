namespace Searching.Implementation
{
    internal class OrderAgnosticBinarySearch
    {

        /*
         * Order Agnostic Binary search
         *  Apply Binary search when Order of the Binary search is not given
         */

        /// <summary>
        /// return the index of target element if the target found in the array array otherwise -1 when order of array is not given
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] arr, int target)
        {
            // Ascending order
            bool isAscending = arr[0] < arr[arr.Length - 1];

            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                // find the middle element between start and end index
                int mid = start + (end - start) / 2; // to avoid integer value overflow, star t + end may exceed the int size 
                // target is found at middle, return the mid
                if (arr[mid] == target)
                    return mid;

                if (isAscending)
                {
                    // if target is greater than mid element, means target is present at right of mid
                    if (target > arr[mid])
                        start = mid + 1;
                    // if target is less than mid element, means target is present at left of mid
                    else
                        end = mid - 1;
                }
                else
                {
                    // if target is greater than mid element, means target is present at left of mid
                    if (target > arr[mid])
                        end = mid - 1;
                    // if target is less than mid element, means target is present at right of mid
                    else
                        start = mid + 1;
                }
            }

            // while loop has ended, but element doesn't found - target element is not present in the list or array
            return -1;
        }
    }
}
