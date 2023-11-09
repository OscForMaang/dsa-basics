using System.Collections.Generic;

namespace Heap.Implementation
{
    public class Heap
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(new MaxHeapComparer());

    }

    public class MaxHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }

}
