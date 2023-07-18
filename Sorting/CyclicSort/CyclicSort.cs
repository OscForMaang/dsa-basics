namespace Sorting.CyclicSort
{
    internal class CyclicSort
    {
        /*
         * Cyclic Sort 
         *  1. When given nos  from range 1 , N => Use cyclic sort
         */
        /// <summary>
        /// Sort using cyclic sort
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr) {

            int end = arr.Length;
            int start = 0;

            while (start < end)
            {
                int correct = arr[start] - 1;
                if (arr[start] != arr[correct]) { 
                    int temp = arr[start];
                    arr[start] = arr[correct];
                    arr[correct] = temp;
                }
                else
                {
                    start++;
                }
            }
        }  
    }
}
