namespace Heap.Practice
{
    internal class KthLargestElement
    {
        public int FindKthLargest(int[] nums, int k)
        {
            // min heap
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            foreach (int num in nums)
            {
                priorityQueue.Enqueue(num, num);
                if(priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }

            return priorityQueue.Peek();
        }

       
    }
}
