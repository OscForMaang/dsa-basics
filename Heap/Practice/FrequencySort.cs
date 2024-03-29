namespace Heap.Practice
{
    internal class FrequencySortProblem
    {
        public int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if(map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            PriorityQueue<(int, int), (int, int)> queue = 
                new PriorityQueue<(int, int), (int, int)>(new Comparer());
            foreach (int key in map.Keys)
            {
                int freq = map[key];
                queue.Enqueue((key, freq), (key, freq));
            }

            int[] res = new int[nums.Length];
            int start = 0;
            while(queue.Count > 0)
            {
                (int, int) keyFreq = queue.Dequeue();
                for(int i = 1; i <= keyFreq.Item2; i++)
                {
                    res[start++] = keyFreq.Item1;
                }
            }
            return res;
        }

        class Comparer : IComparer<(int, int)>
        {
            public int Compare((int, int) x, (int, int) y)
            {
                if(x.Item2 == y.Item2)
                {
                    return y.Item1.CompareTo(x.Item1);
                }

                return x.Item2.CompareTo(y.Item2);
            }
        }


    }
}
