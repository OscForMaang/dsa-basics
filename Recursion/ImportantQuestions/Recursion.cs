namespace Recursion.StackImportantQuestions
{
    internal class Recursion
    {
        public void Print(int count)
        {
            if(count == 0)
                return;
            Console.WriteLine(1);
            Print(count - 1);
        }

        // Print Names N Times using recursion
        public void PrintName(int i, int n)
        {
            if (i > n)
                return;

            Console.WriteLine("Abhinandan");
            PrintName(i + 1, n);
        }

        // print 1 to N
        public void PrintNumber1(int i, int n)
        {
            if (i > n) return;
            Console.WriteLine(i);
            PrintNumber1(i + 1, n);
        }

        // print N TO 1
        public void PrintNumberN(int i, int n)
        {
            if(i < 1) return;

            Console.WriteLine(i);
            PrintNumberN(i - 1, n);
        }

        #region
        // Backtracking
        public void PrintNumber2(int i, int n)
        {
          if(i < 1) 
            return;

          PrintNumber2(i - 1, n);
          Console.WriteLine(i);  
        }

        public void PrintNumberN2(int i, int n)
        {
            if (i > n) return;

            PrintNumberN2(i + 1, n);
            Console.WriteLine(i);
        }
        #endregion

        #region

        // ways to write recursion 

        // paramtized
        public void SumOf(int n, int sum)
        {
            if(n < 1)
            {
                Console.WriteLine(sum);
                return;
            }
            SumOf(n - 1, sum + n);

        }

          
        #endregion
    }
}
