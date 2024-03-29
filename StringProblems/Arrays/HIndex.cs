namespace StringArray.Arrays
{
    internal class HIndexProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/h-index/
        /// </summary>
        /// <param name="citations"></param>
        /// <returns></returns>
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int numberOfPaper = 0;
            int res = 0;
            for (int i = citations.Length-1; i >=0 ; i--)
            {
                int citationCount = citations[i];
                numberOfPaper++;

                if(citationCount >= numberOfPaper)
                {
                    res = Math.Max(res, citationCount);
                }
            }

            return -1;
        }
    }
}
