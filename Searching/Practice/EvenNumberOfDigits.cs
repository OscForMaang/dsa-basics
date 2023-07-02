namespace Searching.Practice
{
    internal class EvenNumberOfDigits
    {
        /// <summary>
        /// Given an array nums of integers, return how many of them contains even number of digits
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindEventNumberOfDigits(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                if(GetNumberOfDigits(num) % 2 == 0){
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// returns number of digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int GetNumberOfDigits(int num)
        {
            if(num == 0) 
                return 1;

            // if number is negative, convert it to positive
            if (num < 0)
                num = num * -1;

            int result = 0;

            while (num > 0)
            {
                result++;
                num /= 10;
            }
            return result;
        }


        /// <summary>
        /// return number of digits using math formula
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int GetNumberOfDigits2(int num)
        {
            if (num == 0)
                return 1;

            // if number is negative, convert it to positive
            if (num < 0)
                num = num * -1;

            return (int)Math.Log10(num);
        }
    }
}
