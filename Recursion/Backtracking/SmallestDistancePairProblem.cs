namespace Recursion.Backtracking
{
    internal class SmallestDistancePairProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/find-k-th-smallest-pair-distance/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SmallestDistancePair(int[] nums, int k)
        {
            IList<IList<int>> allPairs = GenerateAllPair(nums);
            // create max heap
            PriorityQueue<int, int> distanceQueue = 
                new PriorityQueue<int, int>(new Comparer());
            foreach(List<int> pair in allPairs)
            {
                int a = pair[0];
                int b = pair[1];
                int distance = Math.Abs(a - b);
                distanceQueue.Enqueue(distance, distance);

                if(distanceQueue.Count > k)
                {
                    distanceQueue.Dequeue();
                }
            }
            return distanceQueue.Peek();
        }
        private IList<IList<int>> GenerateAllPair(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            void Backtrack(int startIndex, List<int> pair)
            {
                if(pair.Count == 2) // to generalize replace it with k
                {
                    result.Add(new List<int>(pair));
                    return;
                }
                HashSet<int> visited = new HashSet<int>();
                for(int i = startIndex; i < nums.Length; i++)
                {
                    if (!visited.Contains(nums[i]))
                    {
                        pair.Add(nums[i]);
                        int index = pair.Count - 1;
                        Backtrack(i + 1, pair);
                        pair.RemoveAt(index);
                    }
                }
            }

            Backtrack(0, new List<int>());
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
