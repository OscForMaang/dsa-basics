namespace Heap.Practice
{
    internal class ConnectRopesToMinimizeCost
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/minimum-cost-of-ropes-1587115620/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public long MinCost(long[] arr, int n)
        {
            // your code here
            PriorityQueue<long, long> queue 
                = new PriorityQueue<long, long>(); 
            foreach (var num in arr)
            {
                queue.Enqueue(num, num);
            }
            long cost = 0;
            while (queue.Count > 1)
            {
                long rope1 = queue.Dequeue();
                long rope2 = queue.Dequeue();
                long newRope = rope1 + rope2;
                cost += newRope;
                queue.Enqueue(newRope, newRope);
            }

            return cost;
        }
    }
}
