namespace StringArray.Arrays
{
    internal class BestTimeToBuyAndSell
    {
        public int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int prevDayPrice = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
               if(prevDayPrice > prices[i]) // previous day price is more than today, book the profit and by the share
               {
                    profit += prices[i-1] - buy;
                    buy = prices[i];
               }
               prevDayPrice = prices[i];
               if (i == prices.Length - 1 && buy < prices[i])
               {
                    profit += prices[i] - buy;
               }
            }
            return profit;
        }
    }
}
