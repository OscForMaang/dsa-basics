namespace LeetCode150.Practice
{
    internal class ContainsDuplicate
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> numToIndexMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if (numToIndexMap.ContainsKey(key))
                {
                    if (Math.Abs(numToIndexMap[key] - i) <= k)
                        return true;
                    else
                        numToIndexMap[key] = i;
                }
                else
                    numToIndexMap.Add(key, i);

            }
            return false;
        }
    }
}
