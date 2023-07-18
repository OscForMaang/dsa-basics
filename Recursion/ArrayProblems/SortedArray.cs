namespace Recursion.ArrayProblems
{
    internal class SortedArray
    {   
        /// <summary>
        /// Find if array is sorted or not
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsArraySorted(int[] arr)
        {
            return IsArraySorted(arr, 0);
        }

        private bool IsArraySorted(int[] arr, int index)
        {
            if (index == arr.Length - 1)
                return true;

            return arr[index] <= arr[index + 1] 
                && IsArraySorted(arr, index + 1);
        }
    }
}
