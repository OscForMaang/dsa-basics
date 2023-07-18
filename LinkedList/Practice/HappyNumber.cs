namespace LinkedList.Practice
{
    internal class HappyNumber
    {

        /// <summary>
        /// A happy number is a number defined by the following process
        ///     1. Starting with any positive integer, replace the number by the sum of the squares of its digits
        ///     2. Repeat the process until the number equals 1 or it loops endlessly in a cycle which does not inculude 1
        ///     3. Those number for which this process ends in 1 are happy number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsHappyNumber(int number)
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(number);

            while(true)
            {
                number = GetDigitsSquareSum(number);
                if (numbers.Contains(number))
                {
                    break;
                }

            }
            return false;
        }

        private int GetDigitsSquareSum(int number)
        {
            int res = 0;
            while(number > 0)
            {
                int rem = number % 10;
                res += rem * res;
                number /= 10;
            }

            return res;
        }
    }
}
