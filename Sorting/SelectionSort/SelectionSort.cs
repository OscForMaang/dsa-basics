namespace Sorting.SelectionSort
{
    internal class SelectionSort
    {
        /*
         * Selection Sort: 
         * Select an element and place it a correct index
         * Approach: Find the max/min element and swap it with correct index
         * Time Complexity : O(N^2) - Best and worst
         * Space Complexity : O(1)
         * Not a stable sort
         * Performs well for small list
         */

        /// <summary>
        /// Sort an array using selection sort
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                // Find the max item in the remaining array and swap with correct index
                int lastIndex = len - i - 1;
                int maxIndex = 0;
                int j;
                for (j = 1; j < lastIndex; j++)
                {
                    if(arr[maxIndex] < arr[j])
                    {
                       maxIndex = j;
                    }
                }
                // Swap it with Last index
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
