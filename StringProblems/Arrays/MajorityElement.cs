namespace StringArray.Arrays
{
    internal class MajorityElementProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/majority-element-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> MajorityElement(int[] nums)
        {
            int count1 = 0, count2 = 0;
            int element1 = int.MinValue, element2 = int.MinValue;
            foreach(int num in nums)
            {
                if (count1 == 0 && element2 != num)
                {
                    count1 = 1;
                    element1 = num;
                }
                else if (count2 == 0 && element1 != num)
                {
                    count2 = 1;
                    element2 = num;
                }
                else if (element1 == num) count1++;
                else if(element2 == num) count2++;
                else
                {
                    count1--;
                    count2--;
                }
            }

            IList<int> result = new List<int>();
            int majfreq = nums.Length / 3;

            count1 = count2 = 0;
            foreach(int num in nums)
            {
                if(element1 == num) count1++;

                if(element2 == num) count2++;
            }

            if (count1 > majfreq)
                result.Add(element1);
            if (count2 > majfreq)
            {
                if(element1 != element2)
                {
                    result.Add(element2);
                }
            }

            return result;
        }
    }
}
