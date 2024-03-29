namespace Heap.Practice
{
    internal class TopKFrequentProblem
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            foreach (int key in map.Keys)
            {
                int freq = map[key];
                queue.Enqueue(key, freq);
                if(queue.Count > k)
                    queue.Dequeue();
            }
            int[] result = new int[queue.Count];
            int start = 0;
            while(queue.Count > 0)
            {
                result[start++] = queue.Dequeue();
            }

            return result;
        }
    }
}
