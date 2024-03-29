namespace Recursion.StackImportantQuestions
{
    internal class MultipleRecursionCalls
    {
        /// <summary>
        /// find nth fibonacci number
        /// O(N^2) TC
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n <= 1)
                return n;

            return Fib(n - 1) + Fib(n-2);
        }
    }
}
