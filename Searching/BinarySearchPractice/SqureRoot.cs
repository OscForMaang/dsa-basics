namespace Searching.BinarySearchPractice
{
    internal class SqureRoot
    {
        /// <summary>
        /// https://leetcode.com/problems/sqrtx/description/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            int start = 1;
            int end = x;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                // mid * mid = will give run time error
                if (mid == x / mid)
                {
                    return mid;
                }
                else if (x / mid < mid)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start - 1;
        }
    }
}
