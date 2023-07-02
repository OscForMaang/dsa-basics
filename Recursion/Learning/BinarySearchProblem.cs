namespace Recursion.Learning
{
    internal class BinarySearchProblem
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 67, 89, 91 };
            Console.WriteLine(BinarySearch(arr, 5 ));
        }

        public static int BinarySearch(int[] arr, int key)
        {
           return BinarySearch(arr, 0, arr.Length-1, key);
        }

        private static int BinarySearch(int[] arr, int start, int end, int key)
        {

            if(start > end)
            {
                return -1;
            }

            int mid = start + (end - start) / 2;

            if (arr[mid] == key)
            {
                return mid;

            }else if (key < arr[mid])
            {
                // Whenever you are calling recursive methods, do as per method's return type
                // For void : Just call the methoD and for any data type return, use the return the recursive call.
                return BinarySearch(arr, start, mid-1, key);
            }
            else
            {
                return BinarySearch(arr, mid + 1, end, key);
            }
        }
    }
}
