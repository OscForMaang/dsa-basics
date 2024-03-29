
namespace StringArray.Arrays
{
    internal class ProductExceptSelfProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/product-of-array-except-self
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int[] prefix = new int[nums.Length];
            prefix[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                prefix[i] = prefix[i + 1] * nums[i];
            }
            int prod = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                result[i] = prefix[i + 1] * prod;
                prod = prod * nums[i];
            }
            result[nums.Length - 1] = prod;
            return result;
        }

        public int[] ProductExceptSelfConstantSpace(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                result[i] = result[i + 1] * nums[i];
            }
            int prod = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                result[i] = result[i + 1] * prod;
                prod = prod * nums[i];
            }
            result[nums.Length - 1] = prod;
            return result;
        }
    }
}
