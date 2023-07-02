namespace Searching.Implementation
{
    internal class LinearSearching
    {
        /// <summary>
        /// Search in the array: return the index of the target if found
        /// Time complexity : O(N) and Space complexity : O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] arr, int target)
        {
            // Search sequential in array
            for (int index = 0; index < arr.Length; index++)
            {
                // check for element at every index if it is equal to target
                if(target  == arr[index])
                    return index;
            }

            // this line will execute if none of the return statements above have executed
            // hence the target is not found
            return -1;
        }

        /// <summary>
        /// Search in the array: return the index of the target if found, using foreach loop
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search1(int[] arr, int target)
        {
            foreach (var key in arr)
            {
                // check for element at every index if it is equal to target
                if (target == key)
                    return key;
            }

            // this line will execute if none of the return statements above have executed
            // hence the target is not found
            return int.MaxValue;
        }

        /// <summary>
        /// Search in the array: return true if the target found
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search3(int[] arr, int target)
        {
            foreach (var key in arr)
            {
                // check for element at every index if it is equal to target
                if (target == key)
                    return true;
            }

            // this line will execute if none of the return statements above have executed
            // hence the target is not found
            return false;
        }
    }
}
