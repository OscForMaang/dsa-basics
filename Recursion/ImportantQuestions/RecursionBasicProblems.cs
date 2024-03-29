namespace Recursion.StackImportantQuestions
{
    internal class RecursionBasicProblems
    {

        /// <summary>
        /// reverse an array
        /// </summary>
        /// <param name="nums"></param>
        public void ReverseUsingTwoPointer(int[] nums, int start, int end)
        {
            if(start >= end)
                return;

            Swap(nums, start, end);
            ReverseUsingTwoPointer(nums, start+1, end-1);
        }

        /// <summary>
        /// reverse an array using single pointer
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="start"></param>
        public void ReverseUsingSinglePointer (int[] nums, int start)
        {
            if (start >= nums.Length / 2)
                return;

            Swap(nums, start, nums.Length - start - 1);
            ReverseUsingSinglePointer(nums, start + 1);
        }

        /// <summary>
        /// Recursive solution for IsPalindrom
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public bool IsPalindrom(string str, int n, int start = 0)
        {
            if (start >= n / 2)
                return true;

            if(str[start] != str[n - start - 1])
                return false;

            return IsPalindrom(str, n, start + 1);
        }


            

        private void Swap(int[] nums, int firstIndex, int secondIndex)
        {
            int temp = nums[firstIndex];
            nums[firstIndex] = nums[secondIndex];
            nums[secondIndex] = temp;
        }
    }
}
