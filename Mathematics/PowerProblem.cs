namespace Mathematics
{
    internal class PowerProblem
    {
        /// <summary>
        /// https://leetcode.com/problems/powx-n/
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n) 
              
        {
            if (n == 0)
                return 1;
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            return Calculate(x, N);
        }

        private double Calculate(double x, long n)
        {
            if (n == 1)
                return x;
            double halfPow = Calculate(x, n / 2);
            return n % 2 == 0 ? halfPow * halfPow : halfPow * halfPow * x;
        }
    }
}
