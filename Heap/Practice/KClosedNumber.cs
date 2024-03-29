namespace Heap.Practice
{
    internal class KClosedNumber
    {
        /// <summary>
        /// Revisit
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<int> result = new List<int>();
            PriorityQueue<int, int> queue = new PriorityQueue<int,int>(new Comparer());
            foreach (int num in arr)
            {
                queue.Enqueue(num, Math.Abs(num - x));
                if(queue.Count > k)
                    queue.Dequeue();
            }

            while(queue.Count > 0)
            {
                result.Add(queue.Dequeue());
            }
            result.Sort();
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
