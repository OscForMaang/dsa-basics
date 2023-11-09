namespace Searching.BinarySearchPractice
{
    internal class RotatedSortedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            // CASE : 1 : Array is not rotated
            if (nums[start] < nums[end])
            {
                // Search between start and end using binary search
                return BinarySearch(nums, start, end, target);
            }
            // Case 2: Array is rotated
            // Find the pivot element: Largest element from the array
            int pivotIndex = FindPivot(nums, start, end);
            // Case 3: this should be taken care by case 1, 
            if (pivotIndex == -1)
            {
                return BinarySearch(nums, start, end, target);
            }

            // Case 3B: When there is a valid pivot element
            // pivot is the largest element in the rotated array
            int result = BinarySearch(nums, start, pivotIndex, target);
            // we have found the target
            if (result != -1)
            {
                return result;
            }
            // otherwise search in second half of the array
            return BinarySearch(nums, pivotIndex + 1, end, target);
        }

        // Method to find the pivot index, pivot index is the index where the largest element of the rotated
        // array is kept
        // this will work when there is no duplicate elements
        private int FindPivot(int[] nums, int start, int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                // Case:1 When mid is greater than the next element
                // In rotated array this is the only place where 2 consecutive index values are in
                // decreasing order 
                if (mid < end && nums[mid] > nums[mid + 1])
                {
                    return mid;
                }
                // Case 2 : when mid smaller than the previous element
                // explanation same as above
                if (mid > start && nums[mid] < nums[mid - 1])
                {
                    return mid - 1;
                }
                // if mid element is less than the start element,
                // it means we are at right side of sorted rotated array
                if (nums[mid] <= nums[start])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }

        // Binary search algorithms
        private int BinarySearch(int[] nums, int start, int end, int target)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                if (target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }
    }
}
