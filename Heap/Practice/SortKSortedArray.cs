namespace Heap.Practice
{
    /// <summary>
    /// /https://www.geeksforgeeks.org/problems/nearly-sorted-1587115620/1?itm_source=geeksforgeeks&itm_medium=article&itm_campaign=bottom_sticky_on_article
    /// </summary>
    internal class SortKSortedArray
    {
        public List<int> nearlySorted(int[] arr, int num, int K)
        {
            //Your code here
            List<int> sorted = new List<int>();
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            foreach (int nums in arr)
            {
                queue.Enqueue(num, num);

                if(queue.Count > K)
                {
                    sorted.Add(queue.Dequeue());
                }
            }

            while(queue.Count > 0)
                sorted.Add(queue.Dequeue());

            return sorted;
        }
    }
}
