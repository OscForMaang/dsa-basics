namespace Recursion.Learning
{
    internal class NumberProblems
    {
        public void PrintOneToN(int n) // Hypothesis : this will print 1 to n
        {
            if(n <= 0) // base condition
            {
                return;
            }

            // Induction steps
            PrintOneToN(n - 1); // this will print from 1 to n-1 
            Console.WriteLine(n); ;
        }

        public void PrintNtoOne(int n) // Hypothesis : this will print n to 1
        {
            if (n <= 0) // base condition
            {
                return;
            }

            // Induction steps
            Console.WriteLine(n);
            PrintNtoOne(n - 1); // Hypothesis : this will print n-1 to 1
        }
    }
}
