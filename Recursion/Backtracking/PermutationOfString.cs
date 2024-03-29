using System.Text;

namespace Recursion.Backtracking
{
    public class PermutationOfString
    {
        /// <summary>
        /// this is a recursive solution 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<string> GenerateStringPermutation(string str)
        {
            List<string> permutation = new List<string>();      
            void Solve(string input, string output)
            {
                if(input.Length == 0)
                {
                    permutation.Add(output);
                    return;
                }
                HashSet<char> charHash = new HashSet<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (!charHash.Contains(input[i]))
                    {
                        charHash.Add(input[i]);
                        string newOutput = $"{output}{input[i]}";
                        string newInput = input.Remove(i, 1);
                        Solve(newInput, newOutput);
                    }
                }
            }
            Solve(str, string.Empty);
            return permutation;
        }

        /// <summary>
        /// solution using backtracking
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<string> GenerateStringPermutationBT(string str)
        {
            List<string> permutation = new List<string>();
            void Backtrack(int start)
            {
                if (start == str.Length-1)
                {
                    permutation.Add(str);
                    return;
                }
                HashSet<char> charHash = new HashSet<char>();
                for (int i = start; i < str.Length; i++)
                {
                    if (!charHash.Contains(str[i]))
                    {
                        charHash.Add(str[i]);
                        str = Swap(str, start, i);
                        Backtrack(start + 1);
                        str = Swap(str, start, i);
                    }
                }
            }
            Backtrack(0);
            return permutation;
        }

        private string Swap(string str, int start, int end)
        {
            StringBuilder sb = new StringBuilder(str);
            char temp = sb[start];
            sb[start] = sb[end];
            sb[end] = temp;
            return sb.ToString();
        }

    }
}
