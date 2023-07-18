namespace Recursion.EasyProblems
{
    internal class ReverseNumber
    {
        /// <summary>
        /// Reverse a number
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Reverse(int nums)
        {
            return Reverse(nums, 0);
        }

        private int Reverse(int nums, int rev)
        {
            if (nums == 0)
            {
                return rev;
            }
            int tempRev = rev * 10 + nums % 10;
            return Reverse(nums/10, tempRev);
        }
    }
}
