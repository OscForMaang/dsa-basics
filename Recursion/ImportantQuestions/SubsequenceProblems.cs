namespace Recursion.StackImportantQuestions
{
    internal class SubsequenceProblems
    {
        /// <summary>
        /// ALL THE ELEMENT IS UNIQUE
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<IList<int>> FindAllSubSet(int[] arr, int n)
        {
            IList<IList<int>> result =  new List<IList<int>>();
            GenetateSubsets(arr, 0, new List<int>(), result);
            return result;
        }

        private void GenetateSubsets(int[] nums, int start, List<int> subset, IList<IList<int>> result)
        {
            if (start == nums.Length)
            {
                List<int> temp = new List<int>(subset);
                result.Add(temp);
                return;
            }

            // not including the element
            GenetateSubsets(nums, start + 1, new List<int>(subset), result);
            // including the element
            subset.Add(nums[start]);
            GenetateSubsets(nums, start + 1, new List<int>(subset), result);
        }



        /// <summary>
        /// ELEMENT is not unique 
        /// Print all unique subset
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> SubsetsWithOutDuplicate(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            void BackTrack(int start, List<int> subset)
            {
                if(start == nums.Length)
                {
                    result.Add(new List<int>(subset));
                    return;
                }

                // All  subsets that include nums[start]
                subset.Add(nums[start]);
                BackTrack(start + 1, subset);
                // all subsets that don't include nums[start]
                subset.RemoveAt(subset.Count - 1);
                while(start < nums.Length && nums[start] == nums[start + 1])
                {
                    start++;
                }
                BackTrack(start + 1, subset);
            }

            BackTrack(0, new List<int>());
            return result;
        }
    }
}
