namespace Recursion.StackImportantQuestions
{
    internal class GenerateAllBalancedParentheses
    {
        /// <summary>
        /// https://leetcode.com/problems/generate-parentheses/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            int open = n;
            int close = n;

            void Solve(int open, int close, string result)
            {
                if(open == 0 && close == 0)
                {
                    list.Add(result);
                    return;
                }
                
                if(open != 0)
                {
                    Solve(open - 1, close, $"{result}(");
                }

                if(close > open)
                {
                    Solve(open, close-1, $"{result})");
                }
            }

            Solve(open - 1, close, "(");

            return list;
        }
    }
}
