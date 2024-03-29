namespace Heap.Practice
{
    internal class KthSmallestElement
    {
        public int KthSmallest(int[] nums, int k)
        {
            // we need max heap
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(new Comparer());
            foreach (int num in nums)
            {
                queue.Enqueue(num, num);
                if(queue.Count > k)
                {
                    queue.Dequeue();
                }
            }
            return queue.Peek();
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }


    }
}
