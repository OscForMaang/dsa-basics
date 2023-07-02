namespace BitwiseOperator.Practice
{
    internal class LonelyNumber
    {
        /// <summary>
        /// Find a number who is present only once, rest are present twice
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLoenlyNumber(int[] nums)
        {
            // we solve this problem using below property of XOR
            // a ^ 0 = a 
            // a ^ a = 0
            int result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
