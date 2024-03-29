namespace Recursion.StackImportantQuestions
{
    internal class PermutationWithSpace
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/permutation-with-spaces3627/1
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public List<string> Permutation(string S)
        {
            List<string> list = new List<string>();
            int len = S.Length;
            void Solve(int start, string result)
            {
                if(start == len)
                {
                    list.Add(result);
                    return;
                }
               
                // with space
                Solve(start + 1, $"{result} {S[start]}");

                // without space
                Solve(start + 1, $"{result}{S[start]}");
            }

            Solve(1, S[0].ToString());
            return list;
        }
    }
}
