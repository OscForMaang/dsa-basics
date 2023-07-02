namespace Searching.Practice
{
    internal class BasicLinerSearchProblem
    {
        /// <summary>
        /// search the target in the given range: return the index if the target element found
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int SearchInRange(int[] arr, int target, int start, int end)
        {
            if (arr.Length == 0)
                return -1;

            // Search sequential in array
            for (int index = start; index < end; index++)
            {
                // check for element at every index if it is equal to target
                if (target == arr[index])
                    return index;
            }

            // this line will execute if none of the return statements above have executed
            // hence the target is not found
            return -1;
        }

        /// <summary>
        /// Return smallest element in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMinimum(int[] arr)
        {
            int min = arr[0];

            foreach (int num in arr)
            {
                // Whenever finds new minimum swap the value with minimum
                if(min < num)
                    min = num;
            }

            return min;
        }

        /// <summary>
        /// Find Maximum in 2D Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMaximum(int[][] arr)
        {
            int max = arr[0][0];

            for(int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    if (arr[row][col] > max)
                        max = arr[row][col];
                }
            }

            return max;
        }
    }
}
