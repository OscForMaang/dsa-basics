using System.Transactions;

namespace Sorting.MergeSort
{
    internal class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length - 1;
            MergeSort(arr, 0, length);
            return arr;
        }

        private void MergeSort(int[] arr, int start, int end)
        {
            if (start == end)
                return; ;

            int mid = start + (end - start) / 2;

            // Sort first half of the array recursively

            MergeSort(arr, start, mid);
            MergeSort(arr, mid + 1, end);

            Merge(arr, start, mid, mid + 1, end);
        }



        private void Merge(int[] arr, int low1, int high1, int low2, int high2)
        {
            vo
        }


        /// <summary>
        /// Merge two sorted array
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private int[] Merge(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            int[] merge = new int[m + n];

            int i = 0, j = 0, k = 0; 

            while(i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    merge[k++] = arr1[i++];
                else
                    merge[k++] = arr2[j++];
            }

            // fill out the remaining left elements
            while (i < m)
                merge[k++] = arr1[i++];

            while(j < n)
                merge[k] = arr2[j++];

            return merge;
        }
    }
}
