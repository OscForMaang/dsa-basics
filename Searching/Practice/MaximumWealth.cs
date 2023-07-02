namespace Searching.Practice
{
    internal class MaximumWealth
    {
        /// <summary>
        /// Find the maximum weath of the customer, ToDo: past the problem url here
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public int FindMaximumWealth(int[][] accounts)
        {
            int max = int.MinValue;
            foreach (var personBankAccount in accounts)
            {
                // add the amount from each back
                int amountSum = personBankAccount.Sum();
                if(amountSum > max)
                {
                    max = amountSum;
                }
            }
            return max;
        }
    }
}
