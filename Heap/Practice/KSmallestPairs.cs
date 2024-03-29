namespace Heap.Practice
{
    public class KSmallestPairsProblem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            // Max heap
            PriorityQueue<(int, int), int> queue = new PriorityQueue<(int, int), int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                bool isBreak = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    queue.Enqueue((nums1[i], nums2[j]), nums1[i] + nums2[j]);
                    if (queue.Count == k)
                    {
                        isBreak = true;
                        break;
                    }
                }

                if(isBreak){
                    break;
                }
            }
            
            IList<IList<int>> result = new List<IList<int>>();
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                result.Add(new List<int>() { item.Item1, item.Item2 });
            }
            return result;
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
