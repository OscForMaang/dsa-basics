namespace Recursion.ArrayProblems
{
    internal class LinearSearch
    {
        // q: what is binary search
        public bool Search(int[] arr, int target)
        {
            return Search(arr, target, 0);
        }

        private bool Search(int[] arr, int target, int index)
        {
            if (index == arr.Length)
                return false;
            return (arr[index] == target) || Search(arr, target, index + 1);   
        }

        public List<int> SearchAllIndex(int[] arr, int target)
        {
            List<int> ans = SearchAllIndex(arr, target, 0);
            return ans;
        }

        private List<int> SearchAllIndex(int[] arr, int target, int index)
        {
            List<int> list = new List<int>();

            if (index == arr.Length)
                return list;

            if (arr[index] == target)
                list.Add(index);

            List<int> ans = SearchAllIndex(arr, target, index + 1);
            list.AddRange(ans);
            return list;
        }
    }
}
