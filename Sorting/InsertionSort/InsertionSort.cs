namespace Sorting.InsertionSort
{
    internal class InsertionSort
    {
        /*
         * Insertion sort
         * We sort the array partially
         *  for every index 
         *      put that index element at the correct index of LHS
         *  Time Complexity : O(N^2), Best case : O(N)
         *  Space Complexity: O(1)
         *  Notes: 
         *      1. It's Adaptive : steps get reduced if array is sorted. no. of swaps reduced as compared to bubble sort
         *      2. Stable
         *      3. Used for smaller values of N 
         *      4. Works good if array is partially sorted
         *      5. Takes part in Hybrid sorting algorithms
         */

        /// <summary>
        /// Sort an Array using selection sort
        /// </summary>
        /// <param name="nums"></param>
        public void Sort(int[] nums) {
            int len = nums.Length;

            // [5,3,4,1,2] => i to run from 0 to 3
            for (int i = 0; i < len - 1; i++)
            {
                // sort the array from i+1 to 0 index
                for(int j = i + 1; j > 0 ; j--)
                {
                    if (nums[j] < nums[j - 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                    else // array is already sorted
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Insertion sort using Loop varient
        /// </summary>
        /// <param name="A"></param>
        public static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
