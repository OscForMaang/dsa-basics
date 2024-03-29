namespace Recursion.StackImportantQuestions
{
    internal class KthGrammarProblem
    {
        public int KthGrammar(int n, int k)
        {
            if( k == 1 && n == 1 )
                return 0;

            int mid = (int)Math.Pow(2, n - 1) / 2;

            if(k <= mid)
            {
                return KthGrammar(n - 1, k);
            }

            return KthGrammar(n - 1, k - mid) == 1 ? 0 : 1;
        }

    }
}
