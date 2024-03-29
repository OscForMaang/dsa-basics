namespace Recursion.Backtracking
{
    internal class Combinations
    {
        /// <summary>
        /// Important :
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            
            void Backtrack(int start, List<int> combination)
            {
                if(k == combination.Count)
                {
                    res.Add(new List<int>(combination));
                    return;
                }
                for(int i = start; i <= n; i++)
                {
                    combination.Add(i);
                    Backtrack(i + 1, combination);
                    combination.Remove(i);
                }
            }

            Backtrack(1, new List<int>());

            return res;
        }
    }
}
