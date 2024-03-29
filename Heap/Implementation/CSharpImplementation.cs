namespace Heap.Implementation
{
    internal class CSharpImplementation
    {
        /// <summary>
        /// k + smallest : max heap
        ///     => 
        /// k + largest : min heap
        /// 
        /// </summary>
        public PriorityQueue<int, int> maxHeap;
        public PriorityQueue<int, int> minHeap;
        public CSharpImplementation()
        {
            minHeap = new PriorityQueue<int, int>(); // min heap
            maxHeap = new PriorityQueue<int, int>(new Comparer()); // min heap
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
