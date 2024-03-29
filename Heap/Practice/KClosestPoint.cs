namespace Heap.Practice
{
    internal class KClosestPointToOrigin
    {
        /// <summary>
        /// https://leetcode.com/problems/k-closest-points-to-origin/description/
        /// </summary>
        /// <param name="points"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[][] KClosest(int[][] points, int k)
        {
            // We need max heap
            // since we are looking for closest 
            // shortest distance from origin we need max heap

            PriorityQueue<(int, int), double> queue = new PriorityQueue<(int, int), double>(new Comparer());
            foreach (int[] point in points)
            {
                int x = point[0];
                int y = point[1];
                double distanceFromOrigin = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                queue.Enqueue((x, y), distanceFromOrigin);
                if (queue.Count > k)
                {
                    queue.Dequeue();
                }
            }

            int[][] result = new int[queue.Count][];
            int start = 0;
            while (queue.Count > 0)
            {
                var coordinate = queue.Dequeue();
                result[start++] = new int[] { coordinate.Item1, coordinate.Item2 };
            }

            return result;
        }

        class Comparer : IComparer<double>
        {
            public int Compare(double x, double y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
