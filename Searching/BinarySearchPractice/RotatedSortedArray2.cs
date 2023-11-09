
namespace Searching.BinarySearchPractice
{
    internal class RotatedSortedArray2
    {
        /// <summary>
        /// https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
        /// Search in a rotated sorted when there are some duplicate elements
        /// RIVISION
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

                // if elements at start, mid and end are equal
                // skip the duplicates
                if (nums[mid] == nums[start] && nums[mid] == nums[end])
                {

                    // if start is pivot
                    if (start < end && nums[start] > nums[start + 1])
                    {
                        return start;
                    }
                    start++;

                    // if end is pivot

                    if (end > start && nums[end] < nums[end - 1])
                    {
                        return end - 1;
                    }
                    end--;
                }
                else if (nums[start] < nums[mid] || (nums[mid] == nums[start] && nums[mid] > nums[end]))
                    start = mid + 1;
                else
                    end = mid -1;
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


        public int FindPivotInDuplicateArray(int[] nums, int start, int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                // Case 1: mid is at the pivot
                if (mid < end && nums[mid] > nums[mid + 1])
                    return mid;
                // Case 2: mid is at pivot + 1
                if (mid > start && nums[mid] < nums[mid - 1])
                    return mid - 1;

                // Case 3: start, mid, end are equal
                // we will skip the start and end;
                else if (nums[mid] == nums[start] && nums[mid] == nums[end])
                {

                    // check if start it self is the pivot
                    if (start < end && nums[start] > nums[start + 1])
                        return start;

                    start++;

                    if (end > start && nums[end] < nums[end - 1])
                    {
                        return end - 1;
                    }
                    end--;
                }
                else if (nums[start] < nums[mid] || (nums[mid] == nums[start] && nums[mid] > nums[end]))
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
