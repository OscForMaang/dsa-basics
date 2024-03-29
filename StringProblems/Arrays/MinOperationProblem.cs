using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray.Arrays
{
    internal class MinOperationProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinOperations(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num] += 1;
                }
                else
                {
                    map[num] = 1;
                }
            }
            int result = 0;
            foreach (int key in map.Keys)
            {
                int freq = map[key];
                if (freq % 3 == 0)
                {
                    result += freq / 3;
                }
                else
                {
                    // try to write the freq in 2*x + 3*y format
                    int y = 2;
                    int x = 0;
                    int num = freq;
                    while (freq % 3 != 0)
                    {
                        freq -= y;
                        x += y;
                    }
                    // if freq is > 0 : we found the numbers in 2*x + 3*y format
                    if (freq > 0)
                    {
                        result += (freq / 3) + (x / 2);
                    }
                    else
                    {
                        if (num % 2 == 0)
                        {
                            result += num / 2;
                        }
                        else
                        {
                            return -1;
                        }
                    }

                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/description/
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        public int MinimumRounds(int[] tasks)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in tasks)
            {
                if (map.ContainsKey(num))
                {
                    map[num] += 1;
                }
                else
                {
                    map[num] = 1;
                }
            }
            int result = 0;
            foreach (int key in map.Keys)
            {
                int freq = map[key];
                if (freq < 2)
                {
                    return -1;
                }
                result += (freq + 2) / 3; // this is not intutive
            }
            return result;
        }
    }
}
