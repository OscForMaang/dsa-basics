namespace StringProblems.Practics
{
    public class StringProblemPractice
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                int start = i;
                int count = 0;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[start] != needle[j])
                    {
                        break;
                    }
                    count++;
                    start++;
                }
                if(count == needle.Length)
                    return start;
            }
            return -1;
        }

        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i + 1] - nums[i] != 1)
                {
                    if (start == i)
                    {
                        result.Add($"{nums[start]}");
                    }
                    else
                    {
                        result.Add($"{nums[start]}->{nums[i]}");
                    }
                    start = i + 1;
                }
            }
            return result;
        }
    }
}
