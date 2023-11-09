namespace Recursion.Learning
{
    internal class SubsetProblems
    {

        /// <summary>
        /// Print subset of the given input string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        public void PrintSubSet(string input, string output)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(output);
                return;
            }
            string output1 = output;
            string output2 = output;
            output2 = output2 + input[0];
            input = input.Remove(0, 1);
            PrintSubSet(input, output1);
            PrintSubSet(input, output2);
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int count = 0;
            Subsets(result, nums, new List<int>(), count);
            return result;
        }

        private void Subsets(IList<IList<int>> result, int[] input, List<int> output, int count)
        {
            if (count == input.Length) // Base condition
            {
                result.Add(output);
                return;
            }
            List<int> op = new List<int>(output);
            op.Add(input[count]); // Adding one element in the output
            Subsets(result, input, output, count + 1); // solving problem when output is unchanged
            Subsets(result, input, op, count + 1); // solving problem when output is changed
        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/problems/permutation-with-spaces3627/1
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        public void PermutationWithSpace(List<string> result, string input, string output) { 
            // Base condition
            if(string.IsNullOrEmpty(input))
            {
                result.Add(output);
                return;
            }
            char ch = input[0];
            input = input.Remove(0, 1);
            PermutationWithSpace(result, input, $"{output}_{ch}");
            PermutationWithSpace(result, input, $"{output}{ch}");
        }
    }
}
