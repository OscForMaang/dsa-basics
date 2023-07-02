namespace Recursion.Learning
{
    internal class FibonacciProblem
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(Fibonacci(6));
        //}

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
        }
    }
}
